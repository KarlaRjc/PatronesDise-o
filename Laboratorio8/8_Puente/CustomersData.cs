using System;
using System.Collections.Generic;

namespace Laboratorio8._8_Puente
{
    class CustomersData : DataObject

  {
    private List<string> _customers = new List<string>();
    private int _current = 0;

    public CustomersData()
    {
        // Datos quemados

        _customers.Add("Jesus Mora");
        _customers.Add("Josue Jimenez");
        _customers.Add("Gabriel Fernandez");
        _customers.Add("Ann Stills");
        _customers.Add("Lisa Giolani");
    }

    public override void NextRecord()
    {
        if (_current <= _customers.Count - 1)
        {
            _current++;
        }
    }

    public override void PriorRecord()
    {
        if (_current > 0)
        {
            _current--;
        }
    }

    public override void AddRecord(string name)
    {
        _customers.Add(name);
    }

    public override void DeleteRecord(string name)
    {
        _customers.Remove(name);
    }

    public override void ShowRecord()
    {
        Console.WriteLine(_customers[_current]);
    }

    public override void ShowAllRecords()
    {
        foreach (string customer in _customers)
        {
            Console.WriteLine(" " + customer);
        }
    }
}

}
