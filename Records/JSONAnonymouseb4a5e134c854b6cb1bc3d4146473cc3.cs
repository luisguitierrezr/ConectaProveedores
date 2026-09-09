using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DecimalRecord
public class JSONRC_48bcd641416d010841cadd26ba5d55da : AbstractRESTStructure<RC_48bcd641416d010841cadd26ba5d55da> {
[JsonProperty("Decimal")]
[JsonPropertyName("Decimal")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrDecimal;

public JSONRC_48bcd641416d010841cadd26ba5d55da() { }

public JSONRC_48bcd641416d010841cadd26ba5d55da (RC_48bcd641416d010841cadd26ba5d55da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDecimal = ConvertToRestWithoutDefaults(s.ssSTDecimal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
  } else {
AttrDecimal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTDecimal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da, RC_48bcd641416d010841cadd26ba5d55da> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da s) => ToStructure(s, config);
}
public static RC_48bcd641416d010841cadd26ba5d55da ToStructure(ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da obj, IBehaviorsConfiguration config) { 
  RC_48bcd641416d010841cadd26ba5d55da s = new RC_48bcd641416d010841cadd26ba5d55da();
  if(obj != null) {
  s.ssSTDecimal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrDecimal, config);
  }
  return s;
}

public static Func<RC_48bcd641416d010841cadd26ba5d55da, ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_48bcd641416d010841cadd26ba5d55da s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da FromStructure(RC_48bcd641416d010841cadd26ba5d55da s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_48bcd641416d010841cadd26ba5d55da(s, config);
}

}


