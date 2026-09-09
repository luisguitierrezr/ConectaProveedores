namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_ESTD_CUENTA_COSMOZResp (HYz+rADTk02Pu1GS_U_jQA)
///  <code>ST_382afa1d8361f400b6ea03403d75e294Structure</code> that represent
/// s <code>ZMXMIMMF_ESTD_CUENTA_COSMOZResp</code> <p>Description: ZMXMIMMF_ESTD_CUENTA_COSMOZResp</p>
/// </summary>
// Name: ZMXMIMMF_ESTD_CUENTA_COSMOZResp
public partial struct ST_382afa1d8361f400b6ea03403d75e294Structure : ITypedRecord<ST_382afa1d8361f400b6ea03403d75e294Structure> {
internal static readonly GlobalObjectKey IdT_DAT_PROV_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*XF1wWBt7p0GhsPS_4VFf_Q");
internal static readonly GlobalObjectKey IdT_FACT_PEN_PAG_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*QynX_l_2qk6JIVQS1nwVGQ");
internal static readonly GlobalObjectKey IdT_FAC_PAG_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NLwXV2RgcUW08yDPUeFw2g");
internal static readonly GlobalObjectKey IdT_FAC_PAG_CAB_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*wNcws8dhyUWGSwjNiG2D4Q");

public RL_467e1836e09ca6c5339502ff533527b0 ssT_DAT_PROV_Out;

public RL_dd107351023827897d1e9d4f7246e1d9 ssT_FACT_PEN_PAG_Out;

public RL_17d58cb91fc4c8d1157864a76942b9ff ssT_FAC_PAG_Out;

public RL_c269559318987f7f9b248e427dd83abb ssT_FAC_PAG_CAB_Out;


public BitArray OptimizedAttributes;

public ST_382afa1d8361f400b6ea03403d75e294Structure() {
OptimizedAttributes = null;
ssT_DAT_PROV_Out = new RL_467e1836e09ca6c5339502ff533527b0();
ssT_FACT_PEN_PAG_Out = new RL_dd107351023827897d1e9d4f7246e1d9();
ssT_FAC_PAG_Out = new RL_17d58cb91fc4c8d1157864a76942b9ff();
ssT_FAC_PAG_CAB_Out = new RL_c269559318987f7f9b248e427dd83abb();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_382afa1d8361f400b6ea03403d75e294Structure r) {
this = r;
}


public static bool operator == (ST_382afa1d8361f400b6ea03403d75e294Structure a, ST_382afa1d8361f400b6ea03403d75e294Structure b) {
if (a.ssT_DAT_PROV_Out != b.ssT_DAT_PROV_Out) return false;
if (a.ssT_FACT_PEN_PAG_Out != b.ssT_FACT_PEN_PAG_Out) return false;
if (a.ssT_FAC_PAG_Out != b.ssT_FAC_PAG_Out) return false;
if (a.ssT_FAC_PAG_CAB_Out != b.ssT_FAC_PAG_CAB_Out) return false;
return true;
}

public static bool operator != (ST_382afa1d8361f400b6ea03403d75e294Structure a, ST_382afa1d8361f400b6ea03403d75e294Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_382afa1d8361f400b6ea03403d75e294Structure)) return false;
return (this == (ST_382afa1d8361f400b6ea03403d75e294Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssT_DAT_PROV_Out.GetHashCode()
 ^ ssT_FACT_PEN_PAG_Out.GetHashCode()
 ^ ssT_FAC_PAG_Out.GetHashCode()
 ^ ssT_FAC_PAG_CAB_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssT_DAT_PROV_Out.RecursiveReset();
ssT_FACT_PEN_PAG_Out.RecursiveReset();
ssT_FAC_PAG_Out.RecursiveReset();
ssT_FAC_PAG_CAB_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssT_DAT_PROV_Out.InternalRecursiveSave();
ssT_FACT_PEN_PAG_Out.InternalRecursiveSave();
ssT_FAC_PAG_Out.InternalRecursiveSave();
ssT_FAC_PAG_CAB_Out.InternalRecursiveSave();
}


public ST_382afa1d8361f400b6ea03403d75e294Structure Duplicate() {
ST_382afa1d8361f400b6ea03403d75e294Structure t;
t.ssT_DAT_PROV_Out = (RL_467e1836e09ca6c5339502ff533527b0)this.ssT_DAT_PROV_Out.Duplicate();
t.ssT_FACT_PEN_PAG_Out = (RL_dd107351023827897d1e9d4f7246e1d9)this.ssT_FACT_PEN_PAG_Out.Duplicate();
t.ssT_FAC_PAG_Out = (RL_17d58cb91fc4c8d1157864a76942b9ff)this.ssT_FAC_PAG_Out.Duplicate();
t.ssT_FAC_PAG_CAB_Out = (RL_c269559318987f7f9b248e427dd83abb)this.ssT_FAC_PAG_CAB_Out.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "t_dat_prov_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_DAT_PROV_Out")) variable.Value = ssT_DAT_PROV_Out; else variable.Optimized = true;
variable.SetFieldName("t_dat_prov_out");
} else if (head == "t_fact_pen_pag_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FACT_PEN_PAG_Out")) variable.Value = ssT_FACT_PEN_PAG_Out; else variable.Optimized = true;
variable.SetFieldName("t_fact_pen_pag_out");
} else if (head == "t_fac_pag_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_Out")) variable.Value = ssT_FAC_PAG_Out; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_out");
} else if (head == "t_fac_pag_cab_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_CAB_Out")) variable.Value = ssT_FAC_PAG_CAB_Out; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_cab_out");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdT_DAT_PROV_Out) {
return ssT_DAT_PROV_Out;
}
if (key == IdT_FACT_PEN_PAG_Out) {
return ssT_FACT_PEN_PAG_Out;
}
if (key == IdT_FAC_PAG_Out) {
return ssT_FAC_PAG_Out;
}
if (key == IdT_FAC_PAG_CAB_Out) {
return ssT_FAC_PAG_CAB_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_DAT_PROV_Out.Key.AsGuid) {
return ssT_DAT_PROV_Out;
}
if (attributeKey == IdT_FACT_PEN_PAG_Out.Key.AsGuid) {
return ssT_FACT_PEN_PAG_Out;
}
if (attributeKey == IdT_FAC_PAG_Out.Key.AsGuid) {
return ssT_FAC_PAG_Out;
}
if (attributeKey == IdT_FAC_PAG_CAB_Out.Key.AsGuid) {
return ssT_FAC_PAG_CAB_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssT_DAT_PROV_Out = new RL_467e1836e09ca6c5339502ff533527b0();
ssT_DAT_PROV_Out.FillFromOther((IOSList) other.AttributeGet(IdT_DAT_PROV_Out));
ssT_FACT_PEN_PAG_Out = new RL_dd107351023827897d1e9d4f7246e1d9();
ssT_FACT_PEN_PAG_Out.FillFromOther((IOSList) other.AttributeGet(IdT_FACT_PEN_PAG_Out));
ssT_FAC_PAG_Out = new RL_17d58cb91fc4c8d1157864a76942b9ff();
ssT_FAC_PAG_Out.FillFromOther((IOSList) other.AttributeGet(IdT_FAC_PAG_Out));
ssT_FAC_PAG_CAB_Out = new RL_c269559318987f7f9b248e427dd83abb();
ssT_FAC_PAG_CAB_Out.FillFromOther((IOSList) other.AttributeGet(IdT_FAC_PAG_CAB_Out));
}
} // ST_382afa1d8361f400b6ea03403d75e294Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_ESTD_CUENTA_COSMOZRespList</code> that represents a record list of
///  <code>ZMXMIMMF_ESTD_CUENTA_COSMOZResp</code>
/// </summary>
public partial class RL_7470db48a4649f9914de221943bbec5e : GenericRecordList<ST_382afa1d8361f400b6ea03403d75e294Structure>, IEnumerable, IEnumerator {

protected override ST_382afa1d8361f400b6ea03403d75e294Structure GetElementDefaultValue() {
return new ST_382afa1d8361f400b6ea03403d75e294Structure();
}

public T[] ToArray<T>(Func<ST_382afa1d8361f400b6ea03403d75e294Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7470db48a4649f9914de221943bbec5e recordList, Func<ST_382afa1d8361f400b6ea03403d75e294Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7470db48a4649f9914de221943bbec5e(ST_382afa1d8361f400b6ea03403d75e294Structure[] array) {
  RL_7470db48a4649f9914de221943bbec5e result = new RL_7470db48a4649f9914de221943bbec5e();
result.InnerFromArray(array);
    return result;
}

public static RL_7470db48a4649f9914de221943bbec5e ToList<T>(T[] array, Func <T, ST_382afa1d8361f400b6ea03403d75e294Structure> converter) {
  RL_7470db48a4649f9914de221943bbec5e result = new RL_7470db48a4649f9914de221943bbec5e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7470db48a4649f9914de221943bbec5e FromRestList<T>(RestList<T> restList, Func <T, ST_382afa1d8361f400b6ea03403d75e294Structure> converter) {
  RL_7470db48a4649f9914de221943bbec5e result = new RL_7470db48a4649f9914de221943bbec5e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7470db48a4649f9914de221943bbec5e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_382afa1d8361f400b6ea03403d75e294Structure> NewList() {
return new RL_7470db48a4649f9914de221943bbec5e();
}


} // RL_7470db48a4649f9914de221943bbec5e
}

