using Services;
using Models;

namespace Controllers
{
    public class ReadAndPersistController
    {
        private ReadAndPersistController _service;

        public ReadAndPersistController()
        {
            _service = new();
        }

        public List<Radar> LoadData()
        {
            return _service.LoadData();
        }

        public bool InsertData(List<Radar> list)
        {
            return _service.InsertData(list);
        }
    }
}
