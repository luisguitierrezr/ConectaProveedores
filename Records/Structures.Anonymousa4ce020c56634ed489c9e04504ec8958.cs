namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DALOpGNW1E6JyeBFBOyJWA)
///  <code>RC_e05385e784b7ab877b391b661988aada</code> that represent
/// s <code>l_ApprovalProcessIdl_IsSelectFirstApproverRecord</code> <p>Description: </p>
/// </summary>
// Name: l_ApprovalProcessIdl_IsSelectFirstApproverRecord
public partial struct RC_e05385e784b7ab877b391b661988aada : ITypedRecord<RC_e05385e784b7ab877b391b661988aada> {
internal static readonly GlobalObjectKey Idl_ApprovalProcessId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eDggEXmpNjsG62A29qdq9g");
internal static readonly GlobalObjectKey Idl_IsSelectFirstApprover = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XgfPK29spiHPsK8jy+C_cg");

public long ssl_ApprovalProcessId;

public bool ssl_IsSelectFirstApprover;


public BitArray OptimizedAttributes;

public RC_e05385e784b7ab877b391b661988aada() {
OptimizedAttributes = null;
ssl_ApprovalProcessId = 0L;
ssl_IsSelectFirstApprover = false;
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
ssl_ApprovalProcessId = r.ReadEntityReferenceLongInteger(index++, "l_ApprovalProcessIdl_IsSelectFirstApproverRecord.l_ApprovalProcessId", 0L);
ssl_IsSelectFirstApprover = r.ReadBoolean(index++, "l_ApprovalProcessIdl_IsSelectFirstApproverRecord.l_IsSelectFirstApprover", false);
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
public void ReadIM(RC_e05385e784b7ab877b391b661988aada r) {
this = r;
}


public static bool operator == (RC_e05385e784b7ab877b391b661988aada a, RC_e05385e784b7ab877b391b661988aada b) {
if (a.ssl_ApprovalProcessId != b.ssl_ApprovalProcessId) return false;
if (a.ssl_IsSelectFirstApprover != b.ssl_IsSelectFirstApprover) return false;
return true;
}

public static bool operator != (RC_e05385e784b7ab877b391b661988aada a, RC_e05385e784b7ab877b391b661988aada b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e05385e784b7ab877b391b661988aada)) return false;
return (this == (RC_e05385e784b7ab877b391b661988aada)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssl_ApprovalProcessId.GetHashCode()
 ^ ssl_IsSelectFirstApprover.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_e05385e784b7ab877b391b661988aada Duplicate() {
RC_e05385e784b7ab877b391b661988aada t;
t.ssl_ApprovalProcessId = this.ssl_ApprovalProcessId;
t.ssl_IsSelectFirstApprover = this.ssl_IsSelectFirstApprover;
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
if (head == "l_approvalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".l_ApprovalProcessId")) variable.Value = ssl_ApprovalProcessId; else variable.Optimized = true;
} else if (head == "l_isselectfirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".l_IsSelectFirstApprover")) variable.Value = ssl_IsSelectFirstApprover; else variable.Optimized = true;
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
if (key == Idl_ApprovalProcessId) {
return ssl_ApprovalProcessId;
}
if (key == Idl_IsSelectFirstApprover) {
return ssl_IsSelectFirstApprover;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idl_ApprovalProcessId.Key.AsGuid) {
return ssl_ApprovalProcessId;
}
if (attributeKey == Idl_IsSelectFirstApprover.Key.AsGuid) {
return ssl_IsSelectFirstApprover;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssl_ApprovalProcessId = (long) other.AttributeGet(Idl_ApprovalProcessId);
ssl_IsSelectFirstApprover = (bool) other.AttributeGet(Idl_IsSelectFirstApprover);
}
} // RC_e05385e784b7ab877b391b661988aada
/// <summary>
/// RecordList type <code>l_ApprovalProcessIdl_IsSelectFirstApproverRecordList</code> that represents a
///  record list of <code>ApprovalProcessIdentifier, Boolean</code>
/// </summary>
public partial class RL_0a71a321cc21354ef6c19d3de9a4eea6 : GenericRecordList<RC_e05385e784b7ab877b391b661988aada>, IEnumerable, IEnumerator {

protected override RC_e05385e784b7ab877b391b661988aada GetElementDefaultValue() {
return new RC_e05385e784b7ab877b391b661988aada();
}

public T[] ToArray<T>(Func<RC_e05385e784b7ab877b391b661988aada, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a71a321cc21354ef6c19d3de9a4eea6 recordList, Func<RC_e05385e784b7ab877b391b661988aada, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a71a321cc21354ef6c19d3de9a4eea6(RC_e05385e784b7ab877b391b661988aada[] array) {
  RL_0a71a321cc21354ef6c19d3de9a4eea6 result = new RL_0a71a321cc21354ef6c19d3de9a4eea6();
result.InnerFromArray(array);
    return result;
}

public static RL_0a71a321cc21354ef6c19d3de9a4eea6 ToList<T>(T[] array, Func <T, RC_e05385e784b7ab877b391b661988aada> converter) {
  RL_0a71a321cc21354ef6c19d3de9a4eea6 result = new RL_0a71a321cc21354ef6c19d3de9a4eea6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a71a321cc21354ef6c19d3de9a4eea6 FromRestList<T>(RestList<T> restList, Func <T, RC_e05385e784b7ab877b391b661988aada> converter) {
  RL_0a71a321cc21354ef6c19d3de9a4eea6 result = new RL_0a71a321cc21354ef6c19d3de9a4eea6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a71a321cc21354ef6c19d3de9a4eea6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e05385e784b7ab877b391b661988aada> NewList() {
return new RL_0a71a321cc21354ef6c19d3de9a4eea6();
}


} // RL_0a71a321cc21354ef6c19d3de9a4eea6
}

