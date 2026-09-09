using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportAccountingExcelStructRecord
public class RESTRC_6c3703fd5f299efe93690e66a0547b14 : AbstractRESTStructure<RC_6c3703fd5f299efe93690e66a0547b14> {
[JsonProperty("ImportAccountingExcelStruct")]
public ssConectaProveedores.RestRecords.RESTST_8f941ad19a4ca08ad77805bcd0ba00f0Structure AttrImportAccountingExcelStruct;

public RESTRC_6c3703fd5f299efe93690e66a0547b14() { }

public RESTRC_6c3703fd5f299efe93690e66a0547b14 (RC_6c3703fd5f299efe93690e66a0547b14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrImportAccountingExcelStruct = ConvertToRestWithoutDefaults(s.ssSTImportAccountingExcelStruct, new ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure(), ssConectaProveedores.RestRecords.RESTST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.FromStructure, config);
  } else {
AttrImportAccountingExcelStruct = ssConectaProveedores.RestRecords.RESTST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.FromStructure(s.ssSTImportAccountingExcelStruct, config);
  }
}

public static RC_6c3703fd5f299efe93690e66a0547b14 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6c3703fd5f299efe93690e66a0547b14 obj) { 
  RC_6c3703fd5f299efe93690e66a0547b14 s = new RC_6c3703fd5f299efe93690e66a0547b14();
  if(obj != null) {
  s.ssSTImportAccountingExcelStruct = ssConectaProveedores.RestRecords.RESTST_8f941ad19a4ca08ad77805bcd0ba00f0Structure.ToStructure(obj.AttrImportAccountingExcelStruct);
  }
  return s;
}

public static Func<RC_6c3703fd5f299efe93690e66a0547b14, ssConectaProveedores.RestRecords.RESTRC_6c3703fd5f299efe93690e66a0547b14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6c3703fd5f299efe93690e66a0547b14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6c3703fd5f299efe93690e66a0547b14 FromStructure(RC_6c3703fd5f299efe93690e66a0547b14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6c3703fd5f299efe93690e66a0547b14(s, config);
}

}


