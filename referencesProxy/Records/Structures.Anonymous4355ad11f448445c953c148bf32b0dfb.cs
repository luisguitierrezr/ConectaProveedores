namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Ea1VQ0j0XESVPBSL8ysN+w)
///  <code>RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3</code> that represents <code>RETURN2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: RETURN2Record
public partial struct RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 : ITypedRecord<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> {
internal static readonly GlobalObjectKey IdRETURN2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XF69pNdW9aMcXI+OOWopww");

public ST_e5256660414a7d3dddc63b7cbdd21e9cStructure ssSTRETURN2;


public static implicit operator ST_e5256660414a7d3dddc63b7cbdd21e9cStructure( RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 r) {
return r.ssSTRETURN2;
}

public static implicit operator RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure r) {
RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 res = new RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 ();
res.ssSTRETURN2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3() {
OptimizedAttributes = null;
ssSTRETURN2 = new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure();
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
    ssSTRETURN2.OptimizedAttributes = value[0];
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
ssSTRETURN2.Read( r, ref index);
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
public void ReadIM(RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 r) {
this = r;
}


public static bool operator == (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 a, RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 b) {
if (a.ssSTRETURN2 != b.ssSTRETURN2) return false;
return true;
}

public static bool operator != (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 a, RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3)) return false;
return (this == (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRETURN2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRETURN2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRETURN2.InternalRecursiveSave();
}


public RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 Duplicate() {
RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 t;
t.ssSTRETURN2 = (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure)this.ssSTRETURN2.Duplicate();
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
if (head == "return2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RETURN2")) variable.Value = ssSTRETURN2; else variable.Optimized = true;
variable.SetFieldName("return2");
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
if (key == IdRETURN2) {
return ssSTRETURN2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRETURN2.Key.AsGuid) {
return ssSTRETURN2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRETURN2.FillFromOther((IRecord) other.AttributeGet(IdRETURN2));
}
} // RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3
/// <summary>
/// RecordList type <code>RETURN2RecordList</code> that represents a record list of
///  <code>RETURN2</code>
/// </summary>
public partial class RL_1c864e142da7d1f1a4bacb0ad2542337 : GenericRecordList<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3>, IEnumerable, IEnumerator {

protected override RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 GetElementDefaultValue() {
return new RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3();
}

public T[] ToArray<T>(Func<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1c864e142da7d1f1a4bacb0ad2542337 recordList, Func<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1c864e142da7d1f1a4bacb0ad2542337(RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3[] array) {
  RL_1c864e142da7d1f1a4bacb0ad2542337 result = new RL_1c864e142da7d1f1a4bacb0ad2542337();
result.InnerFromArray(array);
    return result;
}

public static RL_1c864e142da7d1f1a4bacb0ad2542337 ToList<T>(T[] array, Func <T, RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> converter) {
  RL_1c864e142da7d1f1a4bacb0ad2542337 result = new RL_1c864e142da7d1f1a4bacb0ad2542337();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1c864e142da7d1f1a4bacb0ad2542337 FromRestList<T>(RestList<T> restList, Func <T, RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> converter) {
  RL_1c864e142da7d1f1a4bacb0ad2542337 result = new RL_1c864e142da7d1f1a4bacb0ad2542337();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1c864e142da7d1f1a4bacb0ad2542337() : base() {
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
protected override OSList<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> NewList() {
return new RL_1c864e142da7d1f1a4bacb0ad2542337();
}


} // RL_1c864e142da7d1f1a4bacb0ad2542337
}

