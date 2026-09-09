namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req (18Z1257+EEGBL_RrFmZ7dw)
///  <code>ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure</code> that represent
/// s <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req</code> <p>Description:
///  BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req</p>
/// </summary>
// Name: BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req
public partial struct ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure : ITypedRecord<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> {
internal static readonly GlobalObjectKey IdPI_BUKRS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_dpXWXDYl0SjyJ_i8F_FZg");
internal static readonly GlobalObjectKey IdPI_VENDORNO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*4wDCG_9RxE2wXKnhYpwRsw");
internal static readonly GlobalObjectKey IdTI_RETENCIONES_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*LpVy2JdswEi3jL79L94yFw");

public string ssPI_BUKRS;

public string ssPI_VENDORNO;

public RL_772621b2ef7c10f920402993065f4a21 ssTI_RETENCIONES_In;


public BitArray OptimizedAttributes;

public ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure() {
OptimizedAttributes = null;
ssPI_BUKRS = "";
ssPI_VENDORNO = "";
ssTI_RETENCIONES_In = new RL_772621b2ef7c10f920402993065f4a21();
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
ssPI_BUKRS = r.ReadText(index++, "BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.PI_BUKRS", "");
ssPI_VENDORNO = r.ReadText(index++, "BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.PI_VENDORNO", "");
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
public void ReadIM(ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure r) {
this = r;
}


public static bool operator == (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure a, ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure b) {
if (a.ssPI_BUKRS != b.ssPI_BUKRS) return false;
if (a.ssPI_VENDORNO != b.ssPI_VENDORNO) return false;
if (a.ssTI_RETENCIONES_In != b.ssTI_RETENCIONES_In) return false;
return true;
}

public static bool operator != (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure a, ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure)) return false;
return (this == (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_BUKRS.GetHashCode()
 ^ ssPI_VENDORNO.GetHashCode()
 ^ ssTI_RETENCIONES_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_RETENCIONES_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_RETENCIONES_In.InternalRecursiveSave();
}


public ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure Duplicate() {
ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure t;
t.ssPI_BUKRS = this.ssPI_BUKRS;
t.ssPI_VENDORNO = this.ssPI_VENDORNO;
t.ssTI_RETENCIONES_In = (RL_772621b2ef7c10f920402993065f4a21)this.ssTI_RETENCIONES_In.Duplicate();
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
if (head == "pi_bukrs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_BUKRS")) variable.Value = ssPI_BUKRS; else variable.Optimized = true;
} else if (head == "pi_vendorno") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_VENDORNO")) variable.Value = ssPI_VENDORNO; else variable.Optimized = true;
} else if (head == "ti_retenciones_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_In")) variable.Value = ssTI_RETENCIONES_In; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_in");
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
if (key == IdPI_BUKRS) {
return ssPI_BUKRS;
}
if (key == IdPI_VENDORNO) {
return ssPI_VENDORNO;
}
if (key == IdTI_RETENCIONES_In) {
return ssTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_BUKRS.Key.AsGuid) {
return ssPI_BUKRS;
}
if (attributeKey == IdPI_VENDORNO.Key.AsGuid) {
return ssPI_VENDORNO;
}
if (attributeKey == IdTI_RETENCIONES_In.Key.AsGuid) {
return ssTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_BUKRS = (string) other.AttributeGet(IdPI_BUKRS);
ssPI_VENDORNO = (string) other.AttributeGet(IdPI_VENDORNO);
ssTI_RETENCIONES_In = new RL_772621b2ef7c10f920402993065f4a21();
ssTI_RETENCIONES_In.FillFromOther((IOSList) other.AttributeGet(IdTI_RETENCIONES_In));
}
} // ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure
/// <summary>
/// RecordList type <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqList</code> that represents a record list
///  of <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req</code>
/// </summary>
public partial class RL_5150bc35d9444e65867476bbb5cf29b5 : GenericRecordList<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure>, IEnumerable, IEnumerator {

protected override ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure GetElementDefaultValue() {
return new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure();
}

public T[] ToArray<T>(Func<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5150bc35d9444e65867476bbb5cf29b5 recordList, Func<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5150bc35d9444e65867476bbb5cf29b5(ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure[] array) {
  RL_5150bc35d9444e65867476bbb5cf29b5 result = new RL_5150bc35d9444e65867476bbb5cf29b5();
result.InnerFromArray(array);
    return result;
}

public static RL_5150bc35d9444e65867476bbb5cf29b5 ToList<T>(T[] array, Func <T, ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> converter) {
  RL_5150bc35d9444e65867476bbb5cf29b5 result = new RL_5150bc35d9444e65867476bbb5cf29b5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5150bc35d9444e65867476bbb5cf29b5 FromRestList<T>(RestList<T> restList, Func <T, ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> converter) {
  RL_5150bc35d9444e65867476bbb5cf29b5 result = new RL_5150bc35d9444e65867476bbb5cf29b5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5150bc35d9444e65867476bbb5cf29b5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> NewList() {
return new RL_5150bc35d9444e65867476bbb5cf29b5();
}


} // RL_5150bc35d9444e65867476bbb5cf29b5
}

