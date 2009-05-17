﻿using System.Collections.Generic;
using MVVM_Dialogs.Model;

namespace MVVM_Dialogs.Service
{
	interface IPersonService
	{
		/// <summary>
		/// Gets all persons.
		/// </summary>
		List<Person> Get();
	}
}
