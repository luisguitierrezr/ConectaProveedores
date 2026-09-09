using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportAccountingExcelStructRecord
public class JSONRC_6c3703fd5f299efe93690e66a0547b14 : AbstractRESTStructure<RC_6c3703fd5f299efe93690e66a0547b14> {
[JsonProperty("ImportAccountingExcelStruct")]
[JsonPropertyName("ImportAccountingExcelStruct")]
public ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure AttrImportAccountingExcelStruct;

public JSONRC_6c3703fd5f299efe93690e66a0547b14() { }

public JSONRC_6c3703fd5f299efe93690e66a0547b14 (RC_6c3703fd5f299efe93690e66a0547b14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrImportAccountingExcelStruct = ConvertToRestWithoutDefaults(s.ssSTImportAccountingExcelStruct, new ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure(), ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.FromStructure, config);
  } else {
AttrImportAccountingExcelStruct = ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.FromStructure(s.ssSTImportAccountingExcelStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14, RC_6c3703fd5f299efe93690e66a0547b14> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14 s) => ToStructure(s, config);
}
public static RC_6c3703fd5f299efe93690e66a0547b14 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14 obj, IBehaviorsConfiguration config) { 
  RC_6c3703fd5f299efe93690e66a0547b14 s = new RC_6c3703fd5f299efe93690e66a0547b14();
  if(obj != null) {
  s.ssSTImportAccountingExcelStruct = ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.ToStructure(obj.AttrImportAccountingExcelStruct, config);
  }
  return s;
}

public static Func<RC_6c3703fd5f299efe93690e66a0547b14, ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6c3703fd5f299efe93690e66a0547b14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14 FromStructure(RC_6c3703fd5f299efe93690e66a0547b14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6c3703fd5f299efe93690e66a0547b14(s, config);
}

}


