﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models;

public class PersonModel
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName { get { return $"{ FirstName } { LastName }"; } }
}
