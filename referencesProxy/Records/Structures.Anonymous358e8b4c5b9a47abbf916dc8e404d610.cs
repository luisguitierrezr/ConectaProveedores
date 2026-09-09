namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (TIuONZpbq0e_kW3I5ATWEA)
///  <code>RC_2d1ccecb35012738626c275d8a3d3a9f</code> that represents <code>DirectReportsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DirectReportsRecord
public partial struct RC_2d1ccecb35012738626c275d8a3d3a9f : ITypedRecord<RC_2d1ccecb35012738626c275d8a3d3a9f> {
internal static readonly GlobalObjectKey IdDirectReports = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*y84cLQE1OCdibCddij06nw");

public ST_7d99a0be08bc4d3199f250548e6c4016Structure ssSTDirectReports;


public static implicit operator ST_7d99a0be08bc4d3199f250548e6c4016Structure( RC_2d1ccecb35012738626c275d8a3d3a9f r) {
return r.ssSTDirectReports;
}

public static implicit operator RC_2d1ccecb35012738626c275d8a3d3a9f (ST_7d99a0be08bc4d3199f250548e6c4016Structure r) {
RC_2d1ccecb35012738626c275d8a3d3a9f res = new RC_2d1ccecb35012738626c275d8a3d3a9f ();
res.ssSTDirectReports = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2d1ccecb35012738626c275d8a3d3a9f() {
OptimizedAttributes = null;
ssSTDirectReports = new ST_7d99a0be08bc4d3199f250548e6c4016Structure();
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
    ssSTDirectReports.OptimizedAttributes = value[0];
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
ssSTDirectReports.Read( r, ref index);
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
public void ReadIM(RC_2d1ccecb35012738626c275d8a3d3a9f r) {
this = r;
}


public static bool operator == (RC_2d1ccecb35012738626c275d8a3d3a9f a, RC_2d1ccecb35012738626c275d8a3d3a9f b) {
if (a.ssSTDirectReports != b.ssSTDirectReports) return false;
return true;
}

public static bool operator != (RC_2d1ccecb35012738626c275d8a3d3a9f a, RC_2d1ccecb35012738626c275d8a3d3a9f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2d1ccecb35012738626c275d8a3d3a9f)) return false;
return (this == (RC_2d1ccecb35012738626c275d8a3d3a9f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDirectReports.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDirectReports.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDirectReports.InternalRecursiveSave();
}


public RC_2d1ccecb35012738626c275d8a3d3a9f Duplicate() {
RC_2d1ccecb35012738626c275d8a3d3a9f t;
t.ssSTDirectReports = (ST_7d99a0be08bc4d3199f250548e6c4016Structure)this.ssSTDirectReports.Duplicate();
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
if (head == "directreports") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectReports")) variable.Value = ssSTDirectReports; else variable.Optimized = true;
variable.SetFieldName("directreports");
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
if (key == IdDirectReports) {
return ssSTDirectReports;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirectReports.Key.AsGuid) {
return ssSTDirectReports;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDirectReports.FillFromOther((IRecord) other.AttributeGet(IdDirectReports));
}
} // RC_2d1ccecb35012738626c275d8a3d3a9f
/// <summary>
/// RecordList type <code>DirectReportsRecordList</code> that represents a record list of
///  <code>DirectReports</code>
/// </summary>
public partial class RL_ddc0b8cca5f11e28c8c6ea93bd831493 : GenericRecordList<RC_2d1ccecb35012738626c275d8a3d3a9f>, IEnumerable, IEnumerator {

protected override RC_2d1ccecb35012738626c275d8a3d3a9f GetElementDefaultValue() {
return new RC_2d1ccecb35012738626c275d8a3d3a9f();
}

public T[] ToArray<T>(Func<RC_2d1ccecb35012738626c275d8a3d3a9f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ddc0b8cca5f11e28c8c6ea93bd831493 recordList, Func<RC_2d1ccecb35012738626c275d8a3d3a9f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ddc0b8cca5f11e28c8c6ea93bd831493(RC_2d1ccecb35012738626c275d8a3d3a9f[] array) {
  RL_ddc0b8cca5f11e28c8c6ea93bd831493 result = new RL_ddc0b8cca5f11e28c8c6ea93bd831493();
result.InnerFromArray(array);
    return result;
}

public static RL_ddc0b8cca5f11e28c8c6ea93bd831493 ToList<T>(T[] array, Func <T, RC_2d1ccecb35012738626c275d8a3d3a9f> converter) {
  RL_ddc0b8cca5f11e28c8c6ea93bd831493 result = new RL_ddc0b8cca5f11e28c8c6ea93bd831493();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ddc0b8cca5f11e28c8c6ea93bd831493 FromRestList<T>(RestList<T> restList, Func <T, RC_2d1ccecb35012738626c275d8a3d3a9f> converter) {
  RL_ddc0b8cca5f11e28c8c6ea93bd831493 result = new RL_ddc0b8cca5f11e28c8c6ea93bd831493();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ddc0b8cca5f11e28c8c6ea93bd831493() : base() {
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
protected override OSList<RC_2d1ccecb35012738626c275d8a3d3a9f> NewList() {
return new RL_ddc0b8cca5f11e28c8c6ea93bd831493();
}


} // RL_ddc0b8cca5f11e28c8c6ea93bd831493
}

