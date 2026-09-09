namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (gJLEZO0QGEuKHteXHNyGAw)
///  <code>RC_03baaf9011c29c7810216c701048afb6</code> that represent
/// s <code>CommentTypeFolioCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: CommentTypeFolioCommentRecord
public partial struct RC_03baaf9011c29c7810216c701048afb6 : ITypedRecord<RC_03baaf9011c29c7810216c701048afb6> {
internal static readonly GlobalObjectKey IdCommentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IDwbLI5ay_acqhaKhZyoKA");
internal static readonly GlobalObjectKey IdFolioComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_WlMvWoooT+644ij1orABw");

public EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord ssENCommentType;

public EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment;


public BitArray OptimizedAttributes;

public RC_03baaf9011c29c7810216c701048afb6() {
OptimizedAttributes = null;
ssENCommentType = new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord();
ssENFolioComment = new EN_a75639301080da49357fc03810b8d65fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCommentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioComment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENCommentType.OptimizedAttributes = value[0];
    ssENFolioComment.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENCommentType.OptimizedAttributes;
    all[1] = ssENFolioComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCommentType.Read( r, ref index);
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
public void ReadIM(RC_03baaf9011c29c7810216c701048afb6 r) {
this = r;
}


public static bool operator == (RC_03baaf9011c29c7810216c701048afb6 a, RC_03baaf9011c29c7810216c701048afb6 b) {
if (a.ssENCommentType != b.ssENCommentType) return false;
if (a.ssENFolioComment != b.ssENFolioComment) return false;
return true;
}

public static bool operator != (RC_03baaf9011c29c7810216c701048afb6 a, RC_03baaf9011c29c7810216c701048afb6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_03baaf9011c29c7810216c701048afb6)) return false;
return (this == (RC_03baaf9011c29c7810216c701048afb6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCommentType.GetHashCode()
 ^ ssENFolioComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCommentType.RecursiveReset();
ssENFolioComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCommentType.InternalRecursiveSave();
ssENFolioComment.InternalRecursiveSave();
}


public RC_03baaf9011c29c7810216c701048afb6 Duplicate() {
RC_03baaf9011c29c7810216c701048afb6 t;
t.ssENCommentType = (EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord)this.ssENCommentType.Duplicate();
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
if (head == "commenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentType")) variable.Value = ssENCommentType; else variable.Optimized = true;
variable.SetFieldName("commenttype");
} else if (head == "foliocomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioComment")) variable.Value = ssENFolioComment; else variable.Optimized = true;
variable.SetFieldName("foliocomment");
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
if (key == IdCommentType) {
return ssENCommentType;
}
if (key == IdFolioComment) {
return ssENFolioComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCommentType.Key.AsGuid) {
return ssENCommentType;
}
if (attributeKey == IdFolioComment.Key.AsGuid) {
return ssENFolioComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCommentType.FillFromOther((IRecord) other.AttributeGet(IdCommentType));
ssENFolioComment.FillFromOther((IRecord) other.AttributeGet(IdFolioComment));
}
} // RC_03baaf9011c29c7810216c701048afb6
/// <summary>
/// RecordList type <code>CommentTypeFolioCommentRecordList</code> that represents a record list of
///  <code>CommentType, FolioComment</code>
/// </summary>
public partial class RL_5fec0894721bcc83c763c610a52bfbfd : GenericRecordList<RC_03baaf9011c29c7810216c701048afb6>, IEnumerable, IEnumerator {

protected override RC_03baaf9011c29c7810216c701048afb6 GetElementDefaultValue() {
return new RC_03baaf9011c29c7810216c701048afb6();
}

public T[] ToArray<T>(Func<RC_03baaf9011c29c7810216c701048afb6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5fec0894721bcc83c763c610a52bfbfd recordList, Func<RC_03baaf9011c29c7810216c701048afb6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5fec0894721bcc83c763c610a52bfbfd(RC_03baaf9011c29c7810216c701048afb6[] array) {
  RL_5fec0894721bcc83c763c610a52bfbfd result = new RL_5fec0894721bcc83c763c610a52bfbfd();
result.InnerFromArray(array);
    return result;
}

public static RL_5fec0894721bcc83c763c610a52bfbfd ToList<T>(T[] array, Func <T, RC_03baaf9011c29c7810216c701048afb6> converter) {
  RL_5fec0894721bcc83c763c610a52bfbfd result = new RL_5fec0894721bcc83c763c610a52bfbfd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5fec0894721bcc83c763c610a52bfbfd FromRestList<T>(RestList<T> restList, Func <T, RC_03baaf9011c29c7810216c701048afb6> converter) {
  RL_5fec0894721bcc83c763c610a52bfbfd result = new RL_5fec0894721bcc83c763c610a52bfbfd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5fec0894721bcc83c763c610a52bfbfd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_03baaf9011c29c7810216c701048afb6> NewList() {
return new RL_5fec0894721bcc83c763c610a52bfbfd();
}


} // RL_5fec0894721bcc83c763c610a52bfbfd
}

