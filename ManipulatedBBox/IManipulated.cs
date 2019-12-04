using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatedBBox
{
    public interface IManipulated
    {
        public void set_parent_box(_BBox box);
        public void change_focus();
    }
}
