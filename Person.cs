using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot]
    public class Main
    {
        [XmlElement]
        public List<MainMenuItems> MainMenuItems { get; set; }
    }
	
	public class MainMenuItems
	{
		[XmlElement]
		public List<MenuItem> MenuItems { get; set; }
	}

	public class MenuItem
	{
		[XmlElement]
		public List<Persons> Persons { get; set; }
	}

	public class Persons
	{
		[XmlElement]
		public List<Person> Person { get; set; }
	}
	
	public class Person
    {
        [XmlElement]
        public string First_Name { get; set; }
        [XmlElement]
        public string Second_Name { get; set; }
        [XmlElement]
        public string Age { get; set; }

    }
}
