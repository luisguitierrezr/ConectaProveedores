using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationSupplierRecord
public class RESTRC_db6241df01dbf5b6e7aa17fd129f947a : AbstractRESTStructure<RC_db6241df01dbf5b6e7aa17fd129f947a> {
[JsonProperty("DocumentExtrationSupplier")]
public ssConectaProveedores.RestRecords.RESTST_c1e66f019db37ad740f84fa58db915f9Structure AttrDocumentExtrationSupplier;

public RESTRC_db6241df01dbf5b6e7aa17fd129f947a() { }

public RESTRC_db6241df01dbf5b6e7aa17fd129f947a (RC_db6241df01dbf5b6e7aa17fd129f947a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationSupplier = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationSupplier, new ST_c1e66f019db37ad740f84fa58db915f9Structure(), ssConectaProveedores.RestRecords.RESTST_c1e66f019db37ad740f84fa58db915f9Structure.FromStructure, config);
  } else {
AttrDocumentExtrationSupplier = ssConectaProveedores.RestRecords.RESTST_c1e66f019db37ad740f84fa58db915f9Structure.FromStructure(s.ssSTDocumentExtrationSupplier, config);
  }
}

public static RC_db6241df01dbf5b6e7aa17fd129f947a ToStructure(ssConectaProveedores.RestRecords.RESTRC_db6241df01dbf5b6e7aa17fd129f947a obj) { 
  RC_db6241df01dbf5b6e7aa17fd129f947a s = new RC_db6241df01dbf5b6e7aa17fd129f947a();
  if(obj != null) {
  s.ssSTDocumentExtrationSupplier = ssConectaProveedores.RestRecords.RESTST_c1e66f019db37ad740f84fa58db915f9Structure.ToStructure(obj.AttrDocumentExtrationSupplier);
  }
  return s;
}

public static Func<RC_db6241df01dbf5b6e7aa17fd129f947a, ssConectaProveedores.RestRecords.RESTRC_db6241df01dbf5b6e7aa17fd129f947a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_db6241df01dbf5b6e7aa17fd129f947a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_db6241df01dbf5b6e7aa17fd129f947a FromStructure(RC_db6241df01dbf5b6e7aa17fd129f947a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_db6241df01dbf5b6e7aa17fd129f947a(s, config);
}

}


