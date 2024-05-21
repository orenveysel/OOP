using _12_InterfaceKalitimTekrar.Abstract;
using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
namespace _12_InterfaceKalitimTekrar.DapperServices
{
    public class ProductManager : DapperBaseManager, IProductService
    {
        public List<Product> GetProductsAll()
        {
            string sql = $"Select * From Products";
            var result = Connection.Query<Product>(sql);
            return result.ToList();
        }

        public Product? GetProduct(int id)
        {
            string sql = $"Select * From Products where ProductID ={id}";
            return Connection.QuerySingle<Product>(sql);
        }

        public int Update(int id, string prodName, int supid, int catid, string quantity, double unitPrice, Int16 unitStock, Int16 unitsOrder, Int16 reorderi, byte discount)

        {
            string sqlupdate = $"update Products set  ProductName='{prodName}',SupplierID='{supid}',CategoryID='{catid}',QuantityPerUnit='{quantity}'," +

                $"UnitPrice='{unitPrice}',UnitsInStock='{unitStock}',UnitsOnOrder='{unitsOrder}',ReorderLevel='{reorderi}',Discontinued='{discount}'WHERE ProductID='{id}')";

            return Connection.Execute(sqlupdate);
        }

        public int Delete(int id)

        {
            string sqlDelete = $"Delete from Products where ProductID={id}";

            Console.WriteLine("Silindi");

            return Connection.Execute(sqlDelete);
        }

        public int Add(string prodName, int supid, int catid, string quantity, double unitPrice, Int16 unitStock, Int16 unitsOrder, Int16 reorderi, byte discount)

        {
            string sqladd = $"INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)" +

                 $"Values ('{prodName}',{supid},{catid},{quantity},{unitPrice},{unitStock},{unitsOrder},{reorderi},{discount})";

            Console.WriteLine("Eklendi");

            return Connection.Execute(sqladd);
        }

        public int Add(string sql)
        {
            return Connection.Execute(sql);
        }

        public int Add(Product product)
        {
            string sqladd = $"INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)" +

                 $"Values ('{product.ProductName}','{product.SupplierId}','{product.CategoryID}','{product.QuantityPerUnit}','{product.UnitPrice}','{product.UnitInStock}','{product.UnitsOnOrder}','{product.ReorderLevel}','{product.Discontinued}')";

            Console.WriteLine("Eklendi");

            return Connection.Execute(sqladd);
        }

        public int Delete(string sql)
        {
            return Connection.Execute(sql);
        }

        public int Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public int Update(string sql)
        {
            return Connection.Execute(sql);
        }

        public int Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
