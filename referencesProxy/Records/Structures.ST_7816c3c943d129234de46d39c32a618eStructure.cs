namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] IT_ATTACHMENT (F8OT87jJZ0WK5M3Vhuv3IA)
///  <code>ST_7816c3c943d129234de46d39c32a618eStructure</code> that represent
/// s <code>IT_ATTACHMENT</code> <p>Description: </p>
/// </summary>
// Name: IT_ATTACHMENT
public partial struct ST_7816c3c943d129234de46d39c32a618eStructure : ITypedRecord<ST_7816c3c943d129234de46d39c32a618eStructure> {
internal static readonly GlobalObjectKey IdARC_DOC_ID = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*EqAV2gErek+neSUCh22GNg");
internal static readonly GlobalObjectKey IdARCHIV_ID = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*_qb7hJMqXkS+3u9CkcP3Hg");

public string ssARC_DOC_ID;

public string ssARCHIV_ID;


public BitArray OptimizedAttributes;

public ST_7816c3c943d129234de46d39c32a618eStructure() {
OptimizedAttributes = null;
ssARC_DOC_ID = "";
ssARCHIV_ID = "";
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
ssARC_DOC_ID = r.ReadText(index++, "IT_ATTACHMENT.ARC_DOC_ID", "");
ssARCHIV_ID = r.ReadText(index++, "IT_ATTACHMENT.ARCHIV_ID", "");
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
public void ReadIM(ST_7816c3c943d129234de46d39c32a618eStructure r) {
this = r;
}


public static bool operator == (ST_7816c3c943d129234de46d39c32a618eStructure a, ST_7816c3c943d129234de46d39c32a618eStructure b) {
if (a.ssARC_DOC_ID != b.ssARC_DOC_ID) return false;
if (a.ssARCHIV_ID != b.ssARCHIV_ID) return false;
return true;
}

public static bool operator != (ST_7816c3c943d129234de46d39c32a618eStructure a, ST_7816c3c943d129234de46d39c32a618eStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7816c3c943d129234de46d39c32a618eStructure)) return false;
return (this == (ST_7816c3c943d129234de46d39c32a618eStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssARC_DOC_ID.GetHashCode()
 ^ ssARCHIV_ID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7816c3c943d129234de46d39c32a618eStructure Duplicate() {
ST_7816c3c943d129234de46d39c32a618eStructure t;
t.ssARC_DOC_ID = this.ssARC_DOC_ID;
t.ssARCHIV_ID = this.ssARCHIV_ID;
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
if (head == "arc_doc_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ARC_DOC_ID")) variable.Value = ssARC_DOC_ID; else variable.Optimized = true;
} else if (head == "archiv_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ARCHIV_ID")) variable.Value = ssARCHIV_ID; else variable.Optimized = true;
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
if (key == IdARC_DOC_ID) {
return ssARC_DOC_ID;
}
if (key == IdARCHIV_ID) {
return ssARCHIV_ID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdARC_DOC_ID.Key.AsGuid) {
return ssARC_DOC_ID;
}
if (attributeKey == IdARCHIV_ID.Key.AsGuid) {
return ssARCHIV_ID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssARC_DOC_ID = (string) other.AttributeGet(IdARC_DOC_ID);
ssARCHIV_ID = (string) other.AttributeGet(IdARCHIV_ID);
}
} // ST_7816c3c943d129234de46d39c32a618eStructure
/// <summary>
/// RecordList type <code>IT_ATTACHMENTList</code> that represents a record list of
///  <code>IT_ATTACHMENT</code>
/// </summary>
public partial class RL_cff0038616a202f621fb7082f988995f : GenericRecordList<ST_7816c3c943d129234de46d39c32a618eStructure>, IEnumerable, IEnumerator {

protected override ST_7816c3c943d129234de46d39c32a618eStructure GetElementDefaultValue() {
return new ST_7816c3c943d129234de46d39c32a618eStructure();
}

public T[] ToArray<T>(Func<ST_7816c3c943d129234de46d39c32a618eStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cff0038616a202f621fb7082f988995f recordList, Func<ST_7816c3c943d129234de46d39c32a618eStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cff0038616a202f621fb7082f988995f(ST_7816c3c943d129234de46d39c32a618eStructure[] array) {
  RL_cff0038616a202f621fb7082f988995f result = new RL_cff0038616a202f621fb7082f988995f();
result.InnerFromArray(array);
    return result;
}

public static RL_cff0038616a202f621fb7082f988995f ToList<T>(T[] array, Func <T, ST_7816c3c943d129234de46d39c32a618eStructure> converter) {
  RL_cff0038616a202f621fb7082f988995f result = new RL_cff0038616a202f621fb7082f988995f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cff0038616a202f621fb7082f988995f FromRestList<T>(RestList<T> restList, Func <T, ST_7816c3c943d129234de46d39c32a618eStructure> converter) {
  RL_cff0038616a202f621fb7082f988995f result = new RL_cff0038616a202f621fb7082f988995f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cff0038616a202f621fb7082f988995f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7816c3c943d129234de46d39c32a618eStructure> NewList() {
return new RL_cff0038616a202f621fb7082f988995f();
}


} // RL_cff0038616a202f621fb7082f988995f
}

