using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationSupplierRecord
public class JSONRC_db6241df01dbf5b6e7aa17fd129f947a : AbstractRESTStructure<RC_db6241df01dbf5b6e7aa17fd129f947a> {
[JsonProperty("DocumentExtrationSupplier")]
[JsonPropertyName("DocumentExtrationSupplier")]
public ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure AttrDocumentExtrationSupplier;

public JSONRC_db6241df01dbf5b6e7aa17fd129f947a() { }

public JSONRC_db6241df01dbf5b6e7aa17fd129f947a (RC_db6241df01dbf5b6e7aa17fd129f947a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationSupplier = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationSupplier, new ST_c1e66f019db37ad740f84fa58db915f9Structure(), ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure.FromStructure, config);
  } else {
AttrDocumentExtrationSupplier = ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure.FromStructure(s.ssSTDocumentExtrationSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a, RC_db6241df01dbf5b6e7aa17fd129f947a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a s) => ToStructure(s, config);
}
public static RC_db6241df01dbf5b6e7aa17fd129f947a ToStructure(ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a obj, IBehaviorsConfiguration config) { 
  RC_db6241df01dbf5b6e7aa17fd129f947a s = new RC_db6241df01dbf5b6e7aa17fd129f947a();
  if(obj != null) {
  s.ssSTDocumentExtrationSupplier = ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure.ToStructure(obj.AttrDocumentExtrationSupplier, config);
  }
  return s;
}

public static Func<RC_db6241df01dbf5b6e7aa17fd129f947a, ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_db6241df01dbf5b6e7aa17fd129f947a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a FromStructure(RC_db6241df01dbf5b6e7aa17fd129f947a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_db6241df01dbf5b6e7aa17fd129f947a(s, config);
}

}


