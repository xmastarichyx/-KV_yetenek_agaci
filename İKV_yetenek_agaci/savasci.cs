using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İKV_yetenek_agaci
{
    public partial class savasci : Component
    {
        public savasci()
        {
            InitializeComponent();
        }

        public savasci(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
