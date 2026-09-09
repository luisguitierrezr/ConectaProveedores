using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataRecord
public class JSONRC_7fd286c48691331601c5027580ae5af5 : AbstractRESTStructure<RC_7fd286c48691331601c5027580ae5af5> {
[JsonProperty("FolioSAPData")]
[JsonPropertyName("FolioSAPData")]
public ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

public JSONRC_7fd286c48691331601c5027580ae5af5() { }

public JSONRC_7fd286c48691331601c5027580ae5af5 (RC_7fd286c48691331601c5027580ae5af5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5, RC_7fd286c48691331601c5027580ae5af5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5 s) => ToStructure(s, config);
}
public static RC_7fd286c48691331601c5027580ae5af5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5 obj, IBehaviorsConfiguration config) { 
  RC_7fd286c48691331601c5027580ae5af5 s = new RC_7fd286c48691331601c5027580ae5af5();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData, config);
  }
  return s;
}

public static Func<RC_7fd286c48691331601c5027580ae5af5, ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7fd286c48691331601c5027580ae5af5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5 FromStructure(RC_7fd286c48691331601c5027580ae5af5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7fd286c48691331601c5027580ae5af5(s, config);
}

}


