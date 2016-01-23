using System;
using System.ComponentModel;

namespace ITTrust.UI.Common
{
    using Globalization;

    public static class Category
    {
        [AttributeUsage(AttributeTargets.All)]
        public sealed class ActionAttribute : CategoryAttribute
        {
            public ActionAttribute()
                : base("Action")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class AppearanceAttribute : CategoryAttribute
        {
            public AppearanceAttribute()
                : base("Appearance")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class AsynchronousAttribute : CategoryAttribute
        {
            public AsynchronousAttribute()
                : base("Asynchronous")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class BehaviorAttribute : CategoryAttribute
        {
            public BehaviorAttribute()
                : base("Behavior")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class DataAttribute : CategoryAttribute
        {
            public DataAttribute()
                : base("Data")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class DebugAttribute : LocalizedCategoryAttribute
        {
            public DebugAttribute()
                : base("Debug")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class DefaultAttribute : CategoryAttribute
        {
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class DesignAttribute : CategoryAttribute
        {
            public DesignAttribute()
                : base("Design")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class DragDropAttribute : CategoryAttribute
        {
            public DragDropAttribute()
                : base("DragDrop")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class FocusAttribute : CategoryAttribute
        {
            public FocusAttribute()
                : base("Focus")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class FormatAttribute : CategoryAttribute
        {
            public FormatAttribute()
                : base("Format")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class KeyAttribute : CategoryAttribute
        {
            public KeyAttribute()
                : base("Key")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class LayoutAttribute : CategoryAttribute
        {
            public LayoutAttribute()
                : base("Layout")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class MouseAttribute : CategoryAttribute
        {
            public MouseAttribute()
                : base("Mouse")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class NameAttribute : LocalizedCategoryAttribute
        {
            public NameAttribute()
                : base("Name")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class PropertyChangedAttribute : LocalizedCategoryAttribute
        {
            public PropertyChangedAttribute()
                : base("PropertyChanged")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class WindowStyleAttribute : CategoryAttribute
        {
            public WindowStyleAttribute()
                : base("WindowStyle")
            {
            }
        }

        [AttributeUsage(AttributeTargets.All)]
        public sealed class WizardAttribute : CategoryAttribute
        {
            public WizardAttribute()
                : base("Wizard")
            {
            }
        }
    }
}