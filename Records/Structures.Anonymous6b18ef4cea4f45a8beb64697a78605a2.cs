namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TO8Ya0_qqEW+tkaXp4YFog)
///  <code>RC_57219406c4228befe08a7a4e1abe2c17</code> that represents <code>FolioRejectRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioRejectRecord
public partial struct RC_57219406c4228befe08a7a4e1abe2c17 : ITypedRecord<RC_57219406c4228befe08a7a4e1abe2c17> {
internal static readonly GlobalObjectKey IdFolioReject = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BpQhVyLE74vginpOGr4sFw");

public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure ssSTFolioReject;


public static implicit operator ST_e54bcdc56c6f092fdfed672ad024bfa4Structure( RC_57219406c4228befe08a7a4e1abe2c17 r) {
return r.ssSTFolioReject;
}

public static implicit operator RC_57219406c4228befe08a7a4e1abe2c17 (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure r) {
RC_57219406c4228befe08a7a4e1abe2c17 res = new RC_57219406c4228befe08a7a4e1abe2c17 ();
res.ssSTFolioReject = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_57219406c4228befe08a7a4e1abe2c17() {
OptimizedAttributes = null;
ssSTFolioReject = new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure();
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
    ssSTFolioReject.OptimizedAttributes = value[0];
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
ssSTFolioReject.Read( r, ref index);
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
public void ReadIM(RC_57219406c4228befe08a7a4e1abe2c17 r) {
this = r;
}


public static bool operator == (RC_57219406c4228befe08a7a4e1abe2c17 a, RC_57219406c4228befe08a7a4e1abe2c17 b) {
if (a.ssSTFolioReject != b.ssSTFolioReject) return false;
return true;
}

public static bool operator != (RC_57219406c4228befe08a7a4e1abe2c17 a, RC_57219406c4228befe08a7a4e1abe2c17 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_57219406c4228befe08a7a4e1abe2c17)) return false;
return (this == (RC_57219406c4228befe08a7a4e1abe2c17)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioReject.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioReject.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioReject.InternalRecursiveSave();
}


public RC_57219406c4228befe08a7a4e1abe2c17 Duplicate() {
RC_57219406c4228befe08a7a4e1abe2c17 t;
t.ssSTFolioReject = (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure)this.ssSTFolioReject.Duplicate();
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
if (head == "folioreject") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioReject")) variable.Value = ssSTFolioReject; else variable.Optimized = true;
variable.SetFieldName("folioreject");
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
if (key == IdFolioReject) {
return ssSTFolioReject;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioReject.Key.AsGuid) {
return ssSTFolioReject;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioReject.FillFromOther((IRecord) other.AttributeGet(IdFolioReject));
}
} // RC_57219406c4228befe08a7a4e1abe2c17
/// <summary>
/// RecordList type <code>FolioRejectRecordList</code> that represents a record list of
///  <code>FolioReject</code>
/// </summary>
public partial class RL_323d3e988c62f5d87258ec78c7ee67c5 : GenericRecordList<RC_57219406c4228befe08a7a4e1abe2c17>, IEnumerable, IEnumerator {

protected override RC_57219406c4228befe08a7a4e1abe2c17 GetElementDefaultValue() {
return new RC_57219406c4228befe08a7a4e1abe2c17();
}

public T[] ToArray<T>(Func<RC_57219406c4228befe08a7a4e1abe2c17, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_323d3e988c62f5d87258ec78c7ee67c5 recordList, Func<RC_57219406c4228befe08a7a4e1abe2c17, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_323d3e988c62f5d87258ec78c7ee67c5(RC_57219406c4228befe08a7a4e1abe2c17[] array) {
  RL_323d3e988c62f5d87258ec78c7ee67c5 result = new RL_323d3e988c62f5d87258ec78c7ee67c5();
result.InnerFromArray(array);
    return result;
}

public static RL_323d3e988c62f5d87258ec78c7ee67c5 ToList<T>(T[] array, Func <T, RC_57219406c4228befe08a7a4e1abe2c17> converter) {
  RL_323d3e988c62f5d87258ec78c7ee67c5 result = new RL_323d3e988c62f5d87258ec78c7ee67c5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_323d3e988c62f5d87258ec78c7ee67c5 FromRestList<T>(RestList<T> restList, Func <T, RC_57219406c4228befe08a7a4e1abe2c17> converter) {
  RL_323d3e988c62f5d87258ec78c7ee67c5 result = new RL_323d3e988c62f5d87258ec78c7ee67c5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_323d3e988c62f5d87258ec78c7ee67c5() : base() {
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
protected override OSList<RC_57219406c4228befe08a7a4e1abe2c17> NewList() {
return new RL_323d3e988c62f5d87258ec78c7ee67c5();
}


} // RL_323d3e988c62f5d87258ec78c7ee67c5
}

