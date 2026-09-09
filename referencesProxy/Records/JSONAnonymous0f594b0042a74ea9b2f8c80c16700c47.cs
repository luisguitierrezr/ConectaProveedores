using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BankRecord
public class JSONRC_df806ed45594b8c12dc41d845973c44a : AbstractRESTStructure<RC_df806ed45594b8c12dc41d845973c44a> {
[JsonProperty("Bank")]
[JsonPropertyName("Bank")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord AttrBank;

public JSONRC_df806ed45594b8c12dc41d845973c44a() { }

public JSONRC_df806ed45594b8c12dc41d845973c44a (RC_df806ed45594b8c12dc41d845973c44a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBank = ConvertToRestWithoutDefaults(s.ssENBank, new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure, config);
  } else {
AttrBank = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure(s.ssENBank, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a, RC_df806ed45594b8c12dc41d845973c44a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a s) => ToStructure(s, config);
}
public static RC_df806ed45594b8c12dc41d845973c44a ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a obj, IBehaviorsConfiguration config) { 
  RC_df806ed45594b8c12dc41d845973c44a s = new RC_df806ed45594b8c12dc41d845973c44a();
  if(obj != null) {
  s.ssENBank = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.ToStructure(obj.AttrBank, config);
  }
  return s;
}

public static Func<RC_df806ed45594b8c12dc41d845973c44a, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df806ed45594b8c12dc41d845973c44a s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a FromStructure(RC_df806ed45594b8c12dc41d845973c44a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_df806ed45594b8c12dc41d845973c44a(s, config);
}

}


