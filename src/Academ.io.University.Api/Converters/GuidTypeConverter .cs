using System;
using AutoMapper;

namespace Academ.io.University.Api.Converters
{
    public class GuidTypeConverter :ITypeConverter<string,Guid>
    {
        public Guid Convert(ResolutionContext context)
        {
            return new Guid(context.SourceValue.ToString());
        }
    }
}