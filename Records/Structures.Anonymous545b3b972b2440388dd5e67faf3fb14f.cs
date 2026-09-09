namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lztbVCQrOECN1eZ_rz+xTw)
///  <code>RC_073e413c5402df3d82c2d65d0628594a</code> that represents <code>HomepageKPIRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HomepageKPIRecord
public partial struct RC_073e413c5402df3d82c2d65d0628594a : ITypedRecord<RC_073e413c5402df3d82c2d65d0628594a> {
internal static readonly GlobalObjectKey IdHomepageKPI = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PEE+BwJUPd+CwtZdBihZSg");

public ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure ssSTHomepageKPI;


public static implicit operator ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure( RC_073e413c5402df3d82c2d65d0628594a r) {
return r.ssSTHomepageKPI;
}

public static implicit operator RC_073e413c5402df3d82c2d65d0628594a (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure r) {
RC_073e413c5402df3d82c2d65d0628594a res = new RC_073e413c5402df3d82c2d65d0628594a ();
res.ssSTHomepageKPI = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_073e413c5402df3d82c2d65d0628594a() {
OptimizedAttributes = null;
ssSTHomepageKPI = new ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure();
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
    ssSTHomepageKPI.OptimizedAttributes = value[0];
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
ssSTHomepageKPI.Read( r, ref index);
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
public void ReadIM(RC_073e413c5402df3d82c2d65d0628594a r) {
this = r;
}


public static bool operator == (RC_073e413c5402df3d82c2d65d0628594a a, RC_073e413c5402df3d82c2d65d0628594a b) {
if (a.ssSTHomepageKPI != b.ssSTHomepageKPI) return false;
return true;
}

public static bool operator != (RC_073e413c5402df3d82c2d65d0628594a a, RC_073e413c5402df3d82c2d65d0628594a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_073e413c5402df3d82c2d65d0628594a)) return false;
return (this == (RC_073e413c5402df3d82c2d65d0628594a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHomepageKPI.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHomepageKPI.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHomepageKPI.InternalRecursiveSave();
}


public RC_073e413c5402df3d82c2d65d0628594a Duplicate() {
RC_073e413c5402df3d82c2d65d0628594a t;
t.ssSTHomepageKPI = (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure)this.ssSTHomepageKPI.Duplicate();
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
if (head == "homepagekpi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HomepageKPI")) variable.Value = ssSTHomepageKPI; else variable.Optimized = true;
variable.SetFieldName("homepagekpi");
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
if (key == IdHomepageKPI) {
return ssSTHomepageKPI;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHomepageKPI.Key.AsGuid) {
return ssSTHomepageKPI;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHomepageKPI.FillFromOther((IRecord) other.AttributeGet(IdHomepageKPI));
}
} // RC_073e413c5402df3d82c2d65d0628594a
/// <summary>
/// RecordList type <code>HomepageKPIRecordList</code> that represents a record list of
///  <code>HomepageKPI</code>
/// </summary>
public partial class RL_0b9ed344d44b60e0112a22c99132ee6b : GenericRecordList<RC_073e413c5402df3d82c2d65d0628594a>, IEnumerable, IEnumerator {

protected override RC_073e413c5402df3d82c2d65d0628594a GetElementDefaultValue() {
return new RC_073e413c5402df3d82c2d65d0628594a();
}

public T[] ToArray<T>(Func<RC_073e413c5402df3d82c2d65d0628594a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0b9ed344d44b60e0112a22c99132ee6b recordList, Func<RC_073e413c5402df3d82c2d65d0628594a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0b9ed344d44b60e0112a22c99132ee6b(RC_073e413c5402df3d82c2d65d0628594a[] array) {
  RL_0b9ed344d44b60e0112a22c99132ee6b result = new RL_0b9ed344d44b60e0112a22c99132ee6b();
result.InnerFromArray(array);
    return result;
}

public static RL_0b9ed344d44b60e0112a22c99132ee6b ToList<T>(T[] array, Func <T, RC_073e413c5402df3d82c2d65d0628594a> converter) {
  RL_0b9ed344d44b60e0112a22c99132ee6b result = new RL_0b9ed344d44b60e0112a22c99132ee6b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0b9ed344d44b60e0112a22c99132ee6b FromRestList<T>(RestList<T> restList, Func <T, RC_073e413c5402df3d82c2d65d0628594a> converter) {
  RL_0b9ed344d44b60e0112a22c99132ee6b result = new RL_0b9ed344d44b60e0112a22c99132ee6b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0b9ed344d44b60e0112a22c99132ee6b() : base() {
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
protected override OSList<RC_073e413c5402df3d82c2d65d0628594a> NewList() {
return new RL_0b9ed344d44b60e0112a22c99132ee6b();
}


} // RL_0b9ed344d44b60e0112a22c99132ee6b
}

