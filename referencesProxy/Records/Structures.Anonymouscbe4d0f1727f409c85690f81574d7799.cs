namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (8dDky39ynECFaQ+BV013mQ)
///  <code>RC_01936c4800922decb42c6cd59b069a6c</code> that represents <code>Users3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: Users3Record
public partial struct RC_01936c4800922decb42c6cd59b069a6c : ITypedRecord<RC_01936c4800922decb42c6cd59b069a6c> {
internal static readonly GlobalObjectKey IdUsers3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SGyTAZIA7C20LGzVmwaabA");

public ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure ssSTUsers3;


public static implicit operator ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure( RC_01936c4800922decb42c6cd59b069a6c r) {
return r.ssSTUsers3;
}

public static implicit operator RC_01936c4800922decb42c6cd59b069a6c (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure r) {
RC_01936c4800922decb42c6cd59b069a6c res = new RC_01936c4800922decb42c6cd59b069a6c ();
res.ssSTUsers3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_01936c4800922decb42c6cd59b069a6c() {
OptimizedAttributes = null;
ssSTUsers3 = new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure();
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
    ssSTUsers3.OptimizedAttributes = value[0];
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
ssSTUsers3.Read( r, ref index);
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
public void ReadIM(RC_01936c4800922decb42c6cd59b069a6c r) {
this = r;
}


public static bool operator == (RC_01936c4800922decb42c6cd59b069a6c a, RC_01936c4800922decb42c6cd59b069a6c b) {
if (a.ssSTUsers3 != b.ssSTUsers3) return false;
return true;
}

public static bool operator != (RC_01936c4800922decb42c6cd59b069a6c a, RC_01936c4800922decb42c6cd59b069a6c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_01936c4800922decb42c6cd59b069a6c)) return false;
return (this == (RC_01936c4800922decb42c6cd59b069a6c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUsers3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUsers3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUsers3.InternalRecursiveSave();
}


public RC_01936c4800922decb42c6cd59b069a6c Duplicate() {
RC_01936c4800922decb42c6cd59b069a6c t;
t.ssSTUsers3 = (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure)this.ssSTUsers3.Duplicate();
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
if (head == "users3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Users3")) variable.Value = ssSTUsers3; else variable.Optimized = true;
variable.SetFieldName("users3");
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
if (key == IdUsers3) {
return ssSTUsers3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUsers3.Key.AsGuid) {
return ssSTUsers3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUsers3.FillFromOther((IRecord) other.AttributeGet(IdUsers3));
}
} // RC_01936c4800922decb42c6cd59b069a6c
/// <summary>
/// RecordList type <code>Users3RecordList</code> that represents a record list of <code>Users3</code>
/// </summary>
public partial class RL_f3e66e1e40e71a65ac8f36f6a75a4a0e : GenericRecordList<RC_01936c4800922decb42c6cd59b069a6c>, IEnumerable, IEnumerator {

protected override RC_01936c4800922decb42c6cd59b069a6c GetElementDefaultValue() {
return new RC_01936c4800922decb42c6cd59b069a6c();
}

public T[] ToArray<T>(Func<RC_01936c4800922decb42c6cd59b069a6c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f3e66e1e40e71a65ac8f36f6a75a4a0e recordList, Func<RC_01936c4800922decb42c6cd59b069a6c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f3e66e1e40e71a65ac8f36f6a75a4a0e(RC_01936c4800922decb42c6cd59b069a6c[] array) {
  RL_f3e66e1e40e71a65ac8f36f6a75a4a0e result = new RL_f3e66e1e40e71a65ac8f36f6a75a4a0e();
result.InnerFromArray(array);
    return result;
}

public static RL_f3e66e1e40e71a65ac8f36f6a75a4a0e ToList<T>(T[] array, Func <T, RC_01936c4800922decb42c6cd59b069a6c> converter) {
  RL_f3e66e1e40e71a65ac8f36f6a75a4a0e result = new RL_f3e66e1e40e71a65ac8f36f6a75a4a0e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f3e66e1e40e71a65ac8f36f6a75a4a0e FromRestList<T>(RestList<T> restList, Func <T, RC_01936c4800922decb42c6cd59b069a6c> converter) {
  RL_f3e66e1e40e71a65ac8f36f6a75a4a0e result = new RL_f3e66e1e40e71a65ac8f36f6a75a4a0e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f3e66e1e40e71a65ac8f36f6a75a4a0e() : base() {
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
protected override OSList<RC_01936c4800922decb42c6cd59b069a6c> NewList() {
return new RL_f3e66e1e40e71a65ac8f36f6a75a4a0e();
}


} // RL_f3e66e1e40e71a65ac8f36f6a75a4a0e
}

