using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model {
	class ModParty:DbHelper {
		public ModParty() {
			this.strTable = "party";
			this.strWhere = "(isPass = 1)";
		}
	}
}
