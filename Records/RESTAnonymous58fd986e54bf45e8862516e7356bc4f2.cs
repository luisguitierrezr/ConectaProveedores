using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFilesStructRecord
public class RESTRC_9108d3e2654ece9110f56afaa300db01 : AbstractRESTStructure<RC_9108d3e2654ece9110f56afaa300db01> {
[JsonProperty("FolioFilesStruct")]
public ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure AttrFolioFilesStruct;

public RESTRC_9108d3e2654ece9110f56afaa300db01() { }

public RESTRC_9108d3e2654ece9110f56afaa300db01 (RC_9108d3e2654ece9110f56afaa300db01 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFilesStruct = ConvertToRestWithoutDefaults(s.ssSTFolioFilesStruct, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.FromStructure, config);
  } else {
AttrFolioFilesStruct = ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.FromStructure(s.ssSTFolioFilesStruct, config);
  }
}

public static RC_9108d3e2654ece9110f56afaa300db01 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9108d3e2654ece9110f56afaa300db01 obj) { 
  RC_9108d3e2654ece9110f56afaa300db01 s = new RC_9108d3e2654ece9110f56afaa300db01();
  if(obj != null) {
  s.ssSTFolioFilesStruct = ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure(obj.AttrFolioFilesStruct);
  }
  return s;
}

public static Func<RC_9108d3e2654ece9110f56afaa300db01, ssConectaProveedores.RestRecords.RESTRC_9108d3e2654ece9110f56afaa300db01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9108d3e2654ece9110f56afaa300db01 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9108d3e2654ece9110f56afaa300db01 FromStructure(RC_9108d3e2654ece9110f56afaa300db01 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9108d3e2654ece9110f56afaa300db01(s, config);
}

}


