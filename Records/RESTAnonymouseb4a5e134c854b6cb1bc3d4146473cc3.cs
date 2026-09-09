using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DecimalRecord
public class RESTRC_48bcd641416d010841cadd26ba5d55da : AbstractRESTStructure<RC_48bcd641416d010841cadd26ba5d55da> {
[JsonProperty("Decimal")]
public ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrDecimal;

public RESTRC_48bcd641416d010841cadd26ba5d55da() { }

public RESTRC_48bcd641416d010841cadd26ba5d55da (RC_48bcd641416d010841cadd26ba5d55da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDecimal = ConvertToRestWithoutDefaults(s.ssSTDecimal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
  } else {
AttrDecimal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTDecimal, config);
  }
}

public static RC_48bcd641416d010841cadd26ba5d55da ToStructure(ssConectaProveedores.RestRecords.RESTRC_48bcd641416d010841cadd26ba5d55da obj) { 
  RC_48bcd641416d010841cadd26ba5d55da s = new RC_48bcd641416d010841cadd26ba5d55da();
  if(obj != null) {
  s.ssSTDecimal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrDecimal);
  }
  return s;
}

public static Func<RC_48bcd641416d010841cadd26ba5d55da, ssConectaProveedores.RestRecords.RESTRC_48bcd641416d010841cadd26ba5d55da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_48bcd641416d010841cadd26ba5d55da s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_48bcd641416d010841cadd26ba5d55da FromStructure(RC_48bcd641416d010841cadd26ba5d55da s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_48bcd641416d010841cadd26ba5d55da(s, config);
}

}


