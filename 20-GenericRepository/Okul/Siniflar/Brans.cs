using _20_GenericRepository.Okul.Sanal;

namespace _20_GenericRepository.Okul.Siniflar
{
    public class Brans:BaseEntity<int>
    {
        public string BransAdi { get; set; }
        public ICollection<Ogretmen> Ogretmenler { get; set; } = new HashSet<Ogretmen>();

    }
}