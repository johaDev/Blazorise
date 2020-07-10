﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
#endregion

namespace Blazorise
{
    public partial class Divider : BaseComponent
    {
        #region Members       

        private DividerType type = DividerType.Solid;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.Divider() );
            builder.Append( ClassProvider.DividerType( Type ) );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        [Parameter]
        public DividerType Type
        {
            get => type;
            set
            {
                type = value;

                DirtyClasses();
            }
        }

        [Parameter] public string Text { get; set; }

        #endregion
    }
}
