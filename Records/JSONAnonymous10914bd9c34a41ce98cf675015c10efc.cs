using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommissionsAndLeasesFileStructRecord
public class JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e : AbstractRESTStructure<RC_47bfaf4bccb1bd03e97cb30148a93f4e> {
[JsonProperty("CommissionsAndLeasesFileStruct")]
[JsonPropertyName("CommissionsAndLeasesFileStruct")]
public ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure AttrCommissionsAndLeasesFileStruct;

public JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e() { }

public JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e (RC_47bfaf4bccb1bd03e97cb30148a93f4e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommissionsAndLeasesFileStruct = ConvertToRestWithoutDefaults(s.ssSTCommissionsAndLeasesFileStruct, new ST_0a2958ff44247d7464fd88ba7a80597cStructure(), ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.FromStructure, config);
  } else {
AttrCommissionsAndLeasesFileStruct = ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.FromStructure(s.ssSTCommissionsAndLeasesFileStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e, RC_47bfaf4bccb1bd03e97cb30148a93f4e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e s) => ToStructure(s, config);
}
public static RC_47bfaf4bccb1bd03e97cb30148a93f4e ToStructure(ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e obj, IBehaviorsConfiguration config) { 
  RC_47bfaf4bccb1bd03e97cb30148a93f4e s = new RC_47bfaf4bccb1bd03e97cb30148a93f4e();
  if(obj != null) {
  s.ssSTCommissionsAndLeasesFileStruct = ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure.ToStructure(obj.AttrCommissionsAndLeasesFileStruct, config);
  }
  return s;
}

public static Func<RC_47bfaf4bccb1bd03e97cb30148a93f4e, ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_47bfaf4bccb1bd03e97cb30148a93f4e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e FromStructure(RC_47bfaf4bccb1bd03e97cb30148a93f4e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_47bfaf4bccb1bd03e97cb30148a93f4e(s, config);
}

}


