namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (pZOyxCSOGUCF7M3Z6NHleQ)
///  <code>RC_9682e08607652557f92f63efe40bdcce</code> that represent
/// s <code>ApplicationRole2Record</code> <p>Description: </p>
/// </summary>
// Name: ApplicationRole2Record
public partial struct RC_9682e08607652557f92f63efe40bdcce : ITypedRecord<RC_9682e08607652557f92f63efe40bdcce> {
internal static readonly GlobalObjectKey IdApplicationRole2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*huCClmUHVyX5L2Pv5Avczg");

public ST_5728db9d26b9364eef512c59f8517473Structure ssSTApplicationRole2;


public static implicit operator ST_5728db9d26b9364eef512c59f8517473Structure( RC_9682e08607652557f92f63efe40bdcce r) {
return r.ssSTApplicationRole2;
}

public static implicit operator RC_9682e08607652557f92f63efe40bdcce (ST_5728db9d26b9364eef512c59f8517473Structure r) {
RC_9682e08607652557f92f63efe40bdcce res = new RC_9682e08607652557f92f63efe40bdcce ();
res.ssSTApplicationRole2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9682e08607652557f92f63efe40bdcce() {
OptimizedAttributes = null;
ssSTApplicationRole2 = new ST_5728db9d26b9364eef512c59f8517473Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTApplicationRole2.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTApplicationRole2.Read( r, ref index);
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
public void ReadIM(RC_9682e08607652557f92f63efe40bdcce r) {
this = r;
}


public static bool operator == (RC_9682e08607652557f92f63efe40bdcce a, RC_9682e08607652557f92f63efe40bdcce b) {
if (a.ssSTApplicationRole2 != b.ssSTApplicationRole2) return false;
return true;
}

public static bool operator != (RC_9682e08607652557f92f63efe40bdcce a, RC_9682e08607652557f92f63efe40bdcce b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9682e08607652557f92f63efe40bdcce)) return false;
return (this == (RC_9682e08607652557f92f63efe40bdcce)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTApplicationRole2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTApplicationRole2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTApplicationRole2.InternalRecursiveSave();
}


public RC_9682e08607652557f92f63efe40bdcce Duplicate() {
RC_9682e08607652557f92f63efe40bdcce t;
t.ssSTApplicationRole2 = (ST_5728db9d26b9364eef512c59f8517473Structure)this.ssSTApplicationRole2.Duplicate();
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
if (head == "applicationrole2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole2")) variable.Value = ssSTApplicationRole2; else variable.Optimized = true;
variable.SetFieldName("applicationrole2");
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
if (key == IdApplicationRole2) {
return ssSTApplicationRole2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicationRole2.Key.AsGuid) {
return ssSTApplicationRole2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTApplicationRole2.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole2));
}
} // RC_9682e08607652557f92f63efe40bdcce
/// <summary>
/// RecordList type <code>ApplicationRole2RecordList</code> that represents a record list of
///  <code>ApplicationRole2</code>
/// </summary>
public partial class RL_a01ee62064023ae55c0dc36678a72f30 : GenericRecordList<RC_9682e08607652557f92f63efe40bdcce>, IEnumerable, IEnumerator {

protected override RC_9682e08607652557f92f63efe40bdcce GetElementDefaultValue() {
return new RC_9682e08607652557f92f63efe40bdcce();
}

public T[] ToArray<T>(Func<RC_9682e08607652557f92f63efe40bdcce, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a01ee62064023ae55c0dc36678a72f30 recordList, Func<RC_9682e08607652557f92f63efe40bdcce, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a01ee62064023ae55c0dc36678a72f30(RC_9682e08607652557f92f63efe40bdcce[] array) {
  RL_a01ee62064023ae55c0dc36678a72f30 result = new RL_a01ee62064023ae55c0dc36678a72f30();
result.InnerFromArray(array);
    return result;
}

public static RL_a01ee62064023ae55c0dc36678a72f30 ToList<T>(T[] array, Func <T, RC_9682e08607652557f92f63efe40bdcce> converter) {
  RL_a01ee62064023ae55c0dc36678a72f30 result = new RL_a01ee62064023ae55c0dc36678a72f30();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a01ee62064023ae55c0dc36678a72f30 FromRestList<T>(RestList<T> restList, Func <T, RC_9682e08607652557f92f63efe40bdcce> converter) {
  RL_a01ee62064023ae55c0dc36678a72f30 result = new RL_a01ee62064023ae55c0dc36678a72f30();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a01ee62064023ae55c0dc36678a72f30() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9682e08607652557f92f63efe40bdcce> NewList() {
return new RL_a01ee62064023ae55c0dc36678a72f30();
}


} // RL_a01ee62064023ae55c0dc36678a72f30
}

