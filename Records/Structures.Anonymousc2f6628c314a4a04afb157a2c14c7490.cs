namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jGL2wkoxBEqvsVeiwUx0kA)
///  <code>RC_1658f197750f356b33a03fb0cbecd80a</code> that represents <code>ValidDateStrucRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ValidDateStrucRecord
public partial struct RC_1658f197750f356b33a03fb0cbecd80a : ITypedRecord<RC_1658f197750f356b33a03fb0cbecd80a> {
internal static readonly GlobalObjectKey IdValidDateStruc = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*l_FYFg91azUzoD+wy+zYCg");

public ST_360c3a66fc9951d9de7870c1f87f9bf6Structure ssSTValidDateStruc;


public static implicit operator ST_360c3a66fc9951d9de7870c1f87f9bf6Structure( RC_1658f197750f356b33a03fb0cbecd80a r) {
return r.ssSTValidDateStruc;
}

public static implicit operator RC_1658f197750f356b33a03fb0cbecd80a (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure r) {
RC_1658f197750f356b33a03fb0cbecd80a res = new RC_1658f197750f356b33a03fb0cbecd80a ();
res.ssSTValidDateStruc = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1658f197750f356b33a03fb0cbecd80a() {
OptimizedAttributes = null;
ssSTValidDateStruc = new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure();
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
    ssSTValidDateStruc.OptimizedAttributes = value[0];
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
ssSTValidDateStruc.Read( r, ref index);
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
public void ReadIM(RC_1658f197750f356b33a03fb0cbecd80a r) {
this = r;
}


public static bool operator == (RC_1658f197750f356b33a03fb0cbecd80a a, RC_1658f197750f356b33a03fb0cbecd80a b) {
if (a.ssSTValidDateStruc != b.ssSTValidDateStruc) return false;
return true;
}

public static bool operator != (RC_1658f197750f356b33a03fb0cbecd80a a, RC_1658f197750f356b33a03fb0cbecd80a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1658f197750f356b33a03fb0cbecd80a)) return false;
return (this == (RC_1658f197750f356b33a03fb0cbecd80a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValidDateStruc.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValidDateStruc.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValidDateStruc.InternalRecursiveSave();
}


public RC_1658f197750f356b33a03fb0cbecd80a Duplicate() {
RC_1658f197750f356b33a03fb0cbecd80a t;
t.ssSTValidDateStruc = (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure)this.ssSTValidDateStruc.Duplicate();
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
if (head == "validdatestruc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidDateStruc")) variable.Value = ssSTValidDateStruc; else variable.Optimized = true;
variable.SetFieldName("validdatestruc");
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
if (key == IdValidDateStruc) {
return ssSTValidDateStruc;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValidDateStruc.Key.AsGuid) {
return ssSTValidDateStruc;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValidDateStruc.FillFromOther((IRecord) other.AttributeGet(IdValidDateStruc));
}
} // RC_1658f197750f356b33a03fb0cbecd80a
/// <summary>
/// RecordList type <code>ValidDateStrucRecordList</code> that represents a record list of
///  <code>ValidDateStruc</code>
/// </summary>
public partial class RL_c6dcccbe39ffab66e54b9b020e5015f8 : GenericRecordList<RC_1658f197750f356b33a03fb0cbecd80a>, IEnumerable, IEnumerator {

protected override RC_1658f197750f356b33a03fb0cbecd80a GetElementDefaultValue() {
return new RC_1658f197750f356b33a03fb0cbecd80a();
}

public T[] ToArray<T>(Func<RC_1658f197750f356b33a03fb0cbecd80a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c6dcccbe39ffab66e54b9b020e5015f8 recordList, Func<RC_1658f197750f356b33a03fb0cbecd80a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c6dcccbe39ffab66e54b9b020e5015f8(RC_1658f197750f356b33a03fb0cbecd80a[] array) {
  RL_c6dcccbe39ffab66e54b9b020e5015f8 result = new RL_c6dcccbe39ffab66e54b9b020e5015f8();
result.InnerFromArray(array);
    return result;
}

public static RL_c6dcccbe39ffab66e54b9b020e5015f8 ToList<T>(T[] array, Func <T, RC_1658f197750f356b33a03fb0cbecd80a> converter) {
  RL_c6dcccbe39ffab66e54b9b020e5015f8 result = new RL_c6dcccbe39ffab66e54b9b020e5015f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c6dcccbe39ffab66e54b9b020e5015f8 FromRestList<T>(RestList<T> restList, Func <T, RC_1658f197750f356b33a03fb0cbecd80a> converter) {
  RL_c6dcccbe39ffab66e54b9b020e5015f8 result = new RL_c6dcccbe39ffab66e54b9b020e5015f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c6dcccbe39ffab66e54b9b020e5015f8() : base() {
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
protected override OSList<RC_1658f197750f356b33a03fb0cbecd80a> NewList() {
return new RL_c6dcccbe39ffab66e54b9b020e5015f8();
}


} // RL_c6dcccbe39ffab66e54b9b020e5015f8
}

