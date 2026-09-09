using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_DAT_PROV_Out
public class RESTST_4639a265770186863b3ecaeafd29fb96Structure : AbstractRESTStructure<ST_4639a265770186863b3ecaeafd29fb96Structure> {
[JsonProperty("LIFNR")]
public string AttrLIFNR;

[JsonProperty("NAME1")]
public string AttrNAME1;

[JsonProperty("NAME2")]
public string AttrNAME2;

public RESTST_4639a265770186863b3ecaeafd29fb96Structure() { }

public RESTST_4639a265770186863b3ecaeafd29fb96Structure (ST_4639a265770186863b3ecaeafd29fb96Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLIFNR = ConvertToRestWithoutDefaults(s.ssLIFNR, "");
AttrNAME1 = ConvertToRestWithoutDefaults(s.ssNAME1, "");
AttrNAME2 = ConvertToRestWithoutDefaults(s.ssNAME2, "");
  } else {
AttrLIFNR = s.ssLIFNR;
AttrNAME1 = s.ssNAME1;
AttrNAME2 = s.ssNAME2;
  }
}

public static ST_4639a265770186863b3ecaeafd29fb96Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure obj) { 
  ST_4639a265770186863b3ecaeafd29fb96Structure s = new ST_4639a265770186863b3ecaeafd29fb96Structure();
  if(obj != null) {
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssNAME1 = obj.AttrNAME1 == null ? "" : obj.AttrNAME1;
  s.ssNAME2 = obj.AttrNAME2 == null ? "" : obj.AttrNAME2;
  }
  return s;
}

public static Func<ST_4639a265770186863b3ecaeafd29fb96Structure, ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4639a265770186863b3ecaeafd29fb96Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure FromStructure(ST_4639a265770186863b3ecaeafd29fb96Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure(s, config);
}

}


