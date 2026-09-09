using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovRequestWrapperRecord
public class JSONRC_8683fa01451331ed9f0e01f837305895 : AbstractRESTStructure<RC_8683fa01451331ed9f0e01f837305895> {
[JsonProperty("PostValidacfdiprovRequestWrapper")]
[JsonPropertyName("PostValidacfdiprovRequestWrapper")]
public ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure AttrPostValidacfdiprovRequestWrapper;

public JSONRC_8683fa01451331ed9f0e01f837305895() { }

public JSONRC_8683fa01451331ed9f0e01f837305895 (RC_8683fa01451331ed9f0e01f837305895 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostValidacfdiprovRequestWrapper = ConvertToRestWithoutDefaults(s.ssSTPostValidacfdiprovRequestWrapper, new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure(), ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure.FromStructure, config);
  } else {
AttrPostValidacfdiprovRequestWrapper = ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure.FromStructure(s.ssSTPostValidacfdiprovRequestWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895, RC_8683fa01451331ed9f0e01f837305895> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895 s) => ToStructure(s, config);
}
public static RC_8683fa01451331ed9f0e01f837305895 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895 obj, IBehaviorsConfiguration config) { 
  RC_8683fa01451331ed9f0e01f837305895 s = new RC_8683fa01451331ed9f0e01f837305895();
  if(obj != null) {
  s.ssSTPostValidacfdiprovRequestWrapper = ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure.ToStructure(obj.AttrPostValidacfdiprovRequestWrapper, config);
  }
  return s;
}

public static Func<RC_8683fa01451331ed9f0e01f837305895, ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8683fa01451331ed9f0e01f837305895 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895 FromStructure(RC_8683fa01451331ed9f0e01f837305895 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8683fa01451331ed9f0e01f837305895(s, config);
}

}


