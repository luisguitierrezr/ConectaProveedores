using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidaCfdResultWrapper
public class JSONST_b861b971a77239711f72752e074dae26Structure : AbstractRESTStructure<ST_b861b971a77239711f72752e074dae26Structure> {
[JsonProperty("vigenteSat")]
[JsonPropertyName("vigenteSat")]
public bool? AttrVigenteSat;

[JsonProperty("msgSat")]
[JsonPropertyName("msgSat")]
public string AttrMsgSat;

[JsonProperty("existeUuidSap")]
[JsonPropertyName("existeUuidSap")]
public bool? AttrExisteUuidSap;

[JsonProperty("msgSap")]
[JsonPropertyName("msgSap")]
public string AttrMsgSap;

public JSONST_b861b971a77239711f72752e074dae26Structure() { }

public JSONST_b861b971a77239711f72752e074dae26Structure (ST_b861b971a77239711f72752e074dae26Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVigenteSat = ConvertToRestWithoutDefaults(s.ssVigenteSat, false);
AttrMsgSat = ConvertToRestWithoutDefaults(s.ssMsgSat, "");
AttrExisteUuidSap = ConvertToRestWithoutDefaults(s.ssExisteUuidSap, false);
AttrMsgSap = ConvertToRestWithoutDefaults(s.ssMsgSap, "");
  } else {
AttrVigenteSat = (bool?) s.ssVigenteSat;
AttrMsgSat = s.ssMsgSat;
AttrExisteUuidSap = (bool?) s.ssExisteUuidSap;
AttrMsgSap = s.ssMsgSap;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure, ST_b861b971a77239711f72752e074dae26Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure s) => ToStructure(s, config);
}
public static ST_b861b971a77239711f72752e074dae26Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure obj, IBehaviorsConfiguration config) { 
  ST_b861b971a77239711f72752e074dae26Structure s = new ST_b861b971a77239711f72752e074dae26Structure();
  if(obj != null) {
  s.ssVigenteSat = obj.AttrVigenteSat == null ? false : obj.AttrVigenteSat.Value;
  s.ssMsgSat = obj.AttrMsgSat == null ? "" : obj.AttrMsgSat;
  s.ssExisteUuidSap = obj.AttrExisteUuidSap == null ? false : obj.AttrExisteUuidSap.Value;
  s.ssMsgSap = obj.AttrMsgSap == null ? "" : obj.AttrMsgSap;
  }
  return s;
}

public static Func<ST_b861b971a77239711f72752e074dae26Structure, ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b861b971a77239711f72752e074dae26Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure FromStructure(ST_b861b971a77239711f72752e074dae26Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure(s, config);
}

}


