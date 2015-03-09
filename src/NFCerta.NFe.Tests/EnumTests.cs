namespace NFCerta.NFe.Tests
{
    using System;
    using System.Collections.Generic;
    using Schemas;
    using Schemas.TiposBasicos;
    using Shouldly;
    using Xunit;

    public class EnumTests
    {
        [Fact]
        public void EnumToStringShouldBeName()
        {
            var ambInt = 1;
            var amb = (AmbienteSefaz) ambInt;
            var ambStr = amb.ToString();
            ambStr.ShouldBe("Producao");
        }

        [Fact]
        public void ICMS40ShouldHaveMotDestNullable()
        {
            var icms = new ICMS40()
            {
                motDesICMS = null
            };
        }
    }
}
