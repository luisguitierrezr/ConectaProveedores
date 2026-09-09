namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_ElBa4BY1k29WeahBkHkjw)
///  <code>RC_9a90bc2051b4738eb963dcb1fec11850</code> that represent
/// s <code>LongIntegerIdentifierRecord</code> <p>Description: </p>
/// </summary>
// Name: LongIntegerIdentifierRecord
public partial struct RC_9a90bc2051b4738eb963dcb1fec11850 : ITypedRecord<RC_9a90bc2051b4738eb963dcb1fec11850> {
internal static readonly GlobalObjectKey IdLongIntegerIdentifier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ILyQmrRRjnO5Y9yx_sEYUA");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTLongIntegerIdentifier;


public static implicit operator ST_52a0b4b2bb66d62c40848f2d472a3986Structure( RC_9a90bc2051b4738eb963dcb1fec11850 r) {
return r.ssSTLongIntegerIdentifier;
}

public static implicit operator RC_9a90bc2051b4738eb963dcb1fec11850 (ST_52a0b4b2bb66d62c40848f2d472a3986Structure r) {
RC_9a90bc2051b4738eb963dcb1fec11850 res = new RC_9a90bc2051b4738eb963dcb1fec11850 ();
res.ssSTLongIntegerIdentifier = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9a90bc2051b4738eb963dcb1fec11850() {
OptimizedAttributes = null;
ssSTLongIntegerIdentifier = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
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
    ssSTLongIntegerIdentifier.OptimizedAttributes = value[0];
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
ssSTLongIntegerIdentifier.Read( r, ref index);
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
public void ReadIM(RC_9a90bc2051b4738eb963dcb1fec11850 r) {
this = r;
}


public static bool operator == (RC_9a90bc2051b4738eb963dcb1fec11850 a, RC_9a90bc2051b4738eb963dcb1fec11850 b) {
if (a.ssSTLongIntegerIdentifier != b.ssSTLongIntegerIdentifier) return false;
return true;
}

public static bool operator != (RC_9a90bc2051b4738eb963dcb1fec11850 a, RC_9a90bc2051b4738eb963dcb1fec11850 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9a90bc2051b4738eb963dcb1fec11850)) return false;
return (this == (RC_9a90bc2051b4738eb963dcb1fec11850)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTLongIntegerIdentifier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTLongIntegerIdentifier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTLongIntegerIdentifier.InternalRecursiveSave();
}


public RC_9a90bc2051b4738eb963dcb1fec11850 Duplicate() {
RC_9a90bc2051b4738eb963dcb1fec11850 t;
t.ssSTLongIntegerIdentifier = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTLongIntegerIdentifier.Duplicate();
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
if (head == "longintegeridentifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LongIntegerIdentifier")) variable.Value = ssSTLongIntegerIdentifier; else variable.Optimized = true;
variable.SetFieldName("longintegeridentifier");
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
if (key == IdLongIntegerIdentifier) {
return ssSTLongIntegerIdentifier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLongIntegerIdentifier.Key.AsGuid) {
return ssSTLongIntegerIdentifier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTLongIntegerIdentifier.FillFromOther((IRecord) other.AttributeGet(IdLongIntegerIdentifier));
}
} // RC_9a90bc2051b4738eb963dcb1fec11850
/// <summary>
/// RecordList type <code>LongIntegerIdentifierRecordList</code> that represents a record list of
///  <code>LongIntegerIdentifier</code>
/// </summary>
public partial class RL_a9f1a6e08d9132f15a2ca12cd7672e15 : GenericRecordList<RC_9a90bc2051b4738eb963dcb1fec11850>, IEnumerable, IEnumerator {

protected override RC_9a90bc2051b4738eb963dcb1fec11850 GetElementDefaultValue() {
return new RC_9a90bc2051b4738eb963dcb1fec11850();
}

public T[] ToArray<T>(Func<RC_9a90bc2051b4738eb963dcb1fec11850, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a9f1a6e08d9132f15a2ca12cd7672e15 recordList, Func<RC_9a90bc2051b4738eb963dcb1fec11850, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a9f1a6e08d9132f15a2ca12cd7672e15(RC_9a90bc2051b4738eb963dcb1fec11850[] array) {
  RL_a9f1a6e08d9132f15a2ca12cd7672e15 result = new RL_a9f1a6e08d9132f15a2ca12cd7672e15();
result.InnerFromArray(array);
    return result;
}

public static RL_a9f1a6e08d9132f15a2ca12cd7672e15 ToList<T>(T[] array, Func <T, RC_9a90bc2051b4738eb963dcb1fec11850> converter) {
  RL_a9f1a6e08d9132f15a2ca12cd7672e15 result = new RL_a9f1a6e08d9132f15a2ca12cd7672e15();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a9f1a6e08d9132f15a2ca12cd7672e15 FromRestList<T>(RestList<T> restList, Func <T, RC_9a90bc2051b4738eb963dcb1fec11850> converter) {
  RL_a9f1a6e08d9132f15a2ca12cd7672e15 result = new RL_a9f1a6e08d9132f15a2ca12cd7672e15();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a9f1a6e08d9132f15a2ca12cd7672e15() : base() {
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
protected override OSList<RC_9a90bc2051b4738eb963dcb1fec11850> NewList() {
return new RL_a9f1a6e08d9132f15a2ca12cd7672e15();
}


} // RL_a9f1a6e08d9132f15a2ca12cd7672e15
}

