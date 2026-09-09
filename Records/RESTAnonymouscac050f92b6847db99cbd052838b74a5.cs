using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TotalSumRecord
public class RESTRC_4efb69cb4fc55f904087bd266147c4db : AbstractRESTStructure<RC_4efb69cb4fc55f904087bd266147c4db> {
[JsonProperty("TotalSum")]
public decimal? AttrTotalSum;

public RESTRC_4efb69cb4fc55f904087bd266147c4db() { }

public RESTRC_4efb69cb4fc55f904087bd266147c4db (RC_4efb69cb4fc55f904087bd266147c4db s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotalSum = ConvertToRestWithoutDefaults(s.ssTotalSum, 0.0M);
  } else {
AttrTotalSum = (decimal?) s.ssTotalSum;
  }
}

public static RC_4efb69cb4fc55f904087bd266147c4db ToStructure(ssConectaProveedores.RestRecords.RESTRC_4efb69cb4fc55f904087bd266147c4db obj) { 
  RC_4efb69cb4fc55f904087bd266147c4db s = new RC_4efb69cb4fc55f904087bd266147c4db();
  if(obj != null) {
  s.ssTotalSum = obj.AttrTotalSum == null ? 0.0M : obj.AttrTotalSum.Value;
  }
  return s;
}

public static Func<RC_4efb69cb4fc55f904087bd266147c4db, ssConectaProveedores.RestRecords.RESTRC_4efb69cb4fc55f904087bd266147c4db> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4efb69cb4fc55f904087bd266147c4db s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4efb69cb4fc55f904087bd266147c4db FromStructure(RC_4efb69cb4fc55f904087bd266147c4db s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4efb69cb4fc55f904087bd266147c4db(s, config);
}

}


