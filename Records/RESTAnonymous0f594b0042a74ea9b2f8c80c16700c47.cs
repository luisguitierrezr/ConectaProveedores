using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BankRecord
public class RESTRC_df806ed45594b8c12dc41d845973c44a : AbstractRESTStructure<RC_df806ed45594b8c12dc41d845973c44a> {
[JsonProperty("Bank")]
public ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord AttrBank;

public RESTRC_df806ed45594b8c12dc41d845973c44a() { }

public RESTRC_df806ed45594b8c12dc41d845973c44a (RC_df806ed45594b8c12dc41d845973c44a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBank = ConvertToRestWithoutDefaults(s.ssENBank, new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure, config);
  } else {
AttrBank = ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure(s.ssENBank, config);
  }
}

public static RC_df806ed45594b8c12dc41d845973c44a ToStructure(ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a obj) { 
  RC_df806ed45594b8c12dc41d845973c44a s = new RC_df806ed45594b8c12dc41d845973c44a();
  if(obj != null) {
  s.ssENBank = ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.ToStructure(obj.AttrBank);
  }
  return s;
}

public static Func<RC_df806ed45594b8c12dc41d845973c44a, ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df806ed45594b8c12dc41d845973c44a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a FromStructure(RC_df806ed45594b8c12dc41d845973c44a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a(s, config);
}

}


