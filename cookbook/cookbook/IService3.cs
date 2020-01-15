﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace cookbook
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService3" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        void DoWork();
    }
}
