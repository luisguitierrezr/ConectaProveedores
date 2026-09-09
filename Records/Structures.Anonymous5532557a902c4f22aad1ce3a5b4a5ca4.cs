namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (elUyVSyQIk+q0c46W0pcpA)
///  <code>RC_bd4c69fd286a3fa1bae388a3d68ac007</code> that represents <code>FolioCommentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioCommentRecord
public partial struct RC_bd4c69fd286a3fa1bae388a3d68ac007 : ITypedRecord<RC_bd4c69fd286a3fa1bae388a3d68ac007> {
internal static readonly GlobalObjectKey IdFolioComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_WlMvWoooT+644ij1orABw");

public EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment;


public static implicit operator EN_a75639301080da49357fc03810b8d65fEntityRecord( RC_bd4c69fd286a3fa1bae388a3d68ac007 r) {
return r.ssENFolioComment;
}

public static implicit operator RC_bd4c69fd286a3fa1bae388a3d68ac007 (EN_a75639301080da49357fc03810b8d65fEntityRecord r) {
RC_bd4c69fd286a3fa1bae388a3d68ac007 res = new RC_bd4c69fd286a3fa1bae388a3d68ac007 ();
res.ssENFolioComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioComment.ChangedAttributes = value;
}
get {
    return ssENFolioComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_bd4c69fd286a3fa1bae388a3d68ac007() {
OptimizedAttributes = null;
ssENFolioComment = new EN_a75639301080da49357fc03810b8d65fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioComment.Read( r, ref index);
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
public void ReadIM(RC_bd4c69fd286a3fa1bae388a3d68ac007 r) {
this = r;
}


public static bool operator == (RC_bd4c69fd286a3fa1bae388a3d68ac007 a, RC_bd4c69fd286a3fa1bae388a3d68ac007 b) {
if (a.ssENFolioComment != b.ssENFolioComment) return false;
return true;
}

public static bool operator != (RC_bd4c69fd286a3fa1bae388a3d68ac007 a, RC_bd4c69fd286a3fa1bae388a3d68ac007 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bd4c69fd286a3fa1bae388a3d68ac007)) return false;
return (this == (RC_bd4c69fd286a3fa1bae388a3d68ac007)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioComment.InternalRecursiveSave();
}


public RC_bd4c69fd286a3fa1bae388a3d68ac007 Duplicate() {
RC_bd4c69fd286a3fa1bae388a3d68ac007 t;
t.ssENFolioComment = (EN_a75639301080da49357fc03810b8d65fEntityRecord)this.ssENFolioComment.Duplicate();
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
if (head == "foliocomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioComment")) variable.Value = ssENFolioComment; else variable.Optimized = true;
variable.SetFieldName("foliocomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioComment) {
return ssENFolioComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioComment.Key.AsGuid) {
return ssENFolioComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioComment.FillFromOther((IRecord) other.AttributeGet(IdFolioComment));
}
} // RC_bd4c69fd286a3fa1bae388a3d68ac007
/// <summary>
/// RecordList type <code>FolioCommentRecordList</code> that represents a record list of
///  <code>FolioComment</code>
/// </summary>
public partial class RL_09242f4ee71e01bd257c449a944930cd : GenericRecordList<RC_bd4c69fd286a3fa1bae388a3d68ac007>, IEnumerable, IEnumerator {

protected override RC_bd4c69fd286a3fa1bae388a3d68ac007 GetElementDefaultValue() {
return new RC_bd4c69fd286a3fa1bae388a3d68ac007();
}

public T[] ToArray<T>(Func<RC_bd4c69fd286a3fa1bae388a3d68ac007, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_09242f4ee71e01bd257c449a944930cd recordList, Func<RC_bd4c69fd286a3fa1bae388a3d68ac007, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_09242f4ee71e01bd257c449a944930cd(RC_bd4c69fd286a3fa1bae388a3d68ac007[] array) {
  RL_09242f4ee71e01bd257c449a944930cd result = new RL_09242f4ee71e01bd257c449a944930cd();
result.InnerFromArray(array);
    return result;
}

public static RL_09242f4ee71e01bd257c449a944930cd ToList<T>(T[] array, Func <T, RC_bd4c69fd286a3fa1bae388a3d68ac007> converter) {
  RL_09242f4ee71e01bd257c449a944930cd result = new RL_09242f4ee71e01bd257c449a944930cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_09242f4ee71e01bd257c449a944930cd FromRestList<T>(RestList<T> restList, Func <T, RC_bd4c69fd286a3fa1bae388a3d68ac007> converter) {
  RL_09242f4ee71e01bd257c449a944930cd result = new RL_09242f4ee71e01bd257c449a944930cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_09242f4ee71e01bd257c449a944930cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bd4c69fd286a3fa1bae388a3d68ac007> NewList() {
return new RL_09242f4ee71e01bd257c449a944930cd();
}


} // RL_09242f4ee71e01bd257c449a944930cd
}

