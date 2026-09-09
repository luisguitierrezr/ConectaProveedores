namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (xTKuAlCnJ0aSxs951ivqsg)
///  <code>RC_5b70628cb77b3444c17eb14380b204e1</code> that represents <code>Configuration2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: Configuration2Record
public partial struct RC_5b70628cb77b3444c17eb14380b204e1 : ITypedRecord<RC_5b70628cb77b3444c17eb14380b204e1> {
internal static readonly GlobalObjectKey IdConfiguration2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jGJwW3u3RDTBfrFDgLIE4Q");

public ST_ba6d268a2af779386f4c1aef812147c5Structure ssSTConfiguration2;


public static implicit operator ST_ba6d268a2af779386f4c1aef812147c5Structure( RC_5b70628cb77b3444c17eb14380b204e1 r) {
return r.ssSTConfiguration2;
}

public static implicit operator RC_5b70628cb77b3444c17eb14380b204e1 (ST_ba6d268a2af779386f4c1aef812147c5Structure r) {
RC_5b70628cb77b3444c17eb14380b204e1 res = new RC_5b70628cb77b3444c17eb14380b204e1 ();
res.ssSTConfiguration2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5b70628cb77b3444c17eb14380b204e1() {
OptimizedAttributes = null;
ssSTConfiguration2 = new ST_ba6d268a2af779386f4c1aef812147c5Structure();
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
    ssSTConfiguration2.OptimizedAttributes = value[0];
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
ssSTConfiguration2.Read( r, ref index);
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
public void ReadIM(RC_5b70628cb77b3444c17eb14380b204e1 r) {
this = r;
}


public static bool operator == (RC_5b70628cb77b3444c17eb14380b204e1 a, RC_5b70628cb77b3444c17eb14380b204e1 b) {
if (a.ssSTConfiguration2 != b.ssSTConfiguration2) return false;
return true;
}

public static bool operator != (RC_5b70628cb77b3444c17eb14380b204e1 a, RC_5b70628cb77b3444c17eb14380b204e1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5b70628cb77b3444c17eb14380b204e1)) return false;
return (this == (RC_5b70628cb77b3444c17eb14380b204e1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTConfiguration2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTConfiguration2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTConfiguration2.InternalRecursiveSave();
}


public RC_5b70628cb77b3444c17eb14380b204e1 Duplicate() {
RC_5b70628cb77b3444c17eb14380b204e1 t;
t.ssSTConfiguration2 = (ST_ba6d268a2af779386f4c1aef812147c5Structure)this.ssSTConfiguration2.Duplicate();
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
if (head == "configuration2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Configuration2")) variable.Value = ssSTConfiguration2; else variable.Optimized = true;
variable.SetFieldName("configuration2");
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
if (key == IdConfiguration2) {
return ssSTConfiguration2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdConfiguration2.Key.AsGuid) {
return ssSTConfiguration2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTConfiguration2.FillFromOther((IRecord) other.AttributeGet(IdConfiguration2));
}
} // RC_5b70628cb77b3444c17eb14380b204e1
/// <summary>
/// RecordList type <code>Configuration2RecordList</code> that represents a record list of
///  <code>Configuration2</code>
/// </summary>
public partial class RL_763cf3a260e6347c2edb03559b9278f3 : GenericRecordList<RC_5b70628cb77b3444c17eb14380b204e1>, IEnumerable, IEnumerator {

protected override RC_5b70628cb77b3444c17eb14380b204e1 GetElementDefaultValue() {
return new RC_5b70628cb77b3444c17eb14380b204e1();
}

public T[] ToArray<T>(Func<RC_5b70628cb77b3444c17eb14380b204e1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_763cf3a260e6347c2edb03559b9278f3 recordList, Func<RC_5b70628cb77b3444c17eb14380b204e1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_763cf3a260e6347c2edb03559b9278f3(RC_5b70628cb77b3444c17eb14380b204e1[] array) {
  RL_763cf3a260e6347c2edb03559b9278f3 result = new RL_763cf3a260e6347c2edb03559b9278f3();
result.InnerFromArray(array);
    return result;
}

public static RL_763cf3a260e6347c2edb03559b9278f3 ToList<T>(T[] array, Func <T, RC_5b70628cb77b3444c17eb14380b204e1> converter) {
  RL_763cf3a260e6347c2edb03559b9278f3 result = new RL_763cf3a260e6347c2edb03559b9278f3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_763cf3a260e6347c2edb03559b9278f3 FromRestList<T>(RestList<T> restList, Func <T, RC_5b70628cb77b3444c17eb14380b204e1> converter) {
  RL_763cf3a260e6347c2edb03559b9278f3 result = new RL_763cf3a260e6347c2edb03559b9278f3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_763cf3a260e6347c2edb03559b9278f3() : base() {
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
protected override OSList<RC_5b70628cb77b3444c17eb14380b204e1> NewList() {
return new RL_763cf3a260e6347c2edb03559b9278f3();
}


} // RL_763cf3a260e6347c2edb03559b9278f3
}

