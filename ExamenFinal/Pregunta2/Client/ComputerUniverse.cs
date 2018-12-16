using ExamenParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta2
{
    class ComputerUniverse
    {
        private Memory _memory;
        private Processor _processor;
        private Storage _storage;
        private Finish _finish;

        public ComputerUniverse(Computer factory)
        {
            _memory = factory.memory();
            _processor = factory.processor();
            _storage = factory.storage();
            _finish = factory.finish();
        }

        public string RunCharacteristicsMemory()
        {
            return _memory.getDescription();                                   
        }
        public string RunCharacteristicsProcessor()
        {
            return _processor.getDescription();
        }
        public string RunCharacteristicsStorage()
        {
            return _storage.getDescription();
        }
        public string RunCharacteristicsFinish()
        {
            return _finish.ToString();
        }
    }
}
