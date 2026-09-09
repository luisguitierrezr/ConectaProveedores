namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Uv_i7WzJ3Ei7wRY6DuY6qw)
///  <code>RC_d62ad7391a87381616a77aeae304e183</code> that represent
/// s <code>FolioApprovalFolioRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioRecord
public partial struct RC_d62ad7391a87381616a77aeae304e183 : ITypedRecord<RC_d62ad7391a87381616a77aeae304e183> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;


public BitArray OptimizedAttributes;

public RC_d62ad7391a87381616a77aeae304e183() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
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
public void ReadIM(RC_d62ad7391a87381616a77aeae304e183 r) {
this = r;
}


public static bool operator == (RC_d62ad7391a87381616a77aeae304e183 a, RC_d62ad7391a87381616a77aeae304e183 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
return true;
}

public static bool operator != (RC_d62ad7391a87381616a77aeae304e183 a, RC_d62ad7391a87381616a77aeae304e183 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d62ad7391a87381616a77aeae304e183)) return false;
return (this == (RC_d62ad7391a87381616a77aeae304e183)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
}


public RC_d62ad7391a87381616a77aeae304e183 Duplicate() {
RC_d62ad7391a87381616a77aeae304e183 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
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
if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
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
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolio) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
}
} // RC_d62ad7391a87381616a77aeae304e183
/// <summary>
/// RecordList type <code>FolioApprovalFolioRecordList</code> that represents a record list of
///  <code>FolioApproval, Folio</code>
/// </summary>
public partial class RL_f2334acea7cfd80330b429c488fa4f97 : GenericRecordList<RC_d62ad7391a87381616a77aeae304e183>, IEnumerable, IEnumerator {

protected override RC_d62ad7391a87381616a77aeae304e183 GetElementDefaultValue() {
return new RC_d62ad7391a87381616a77aeae304e183();
}

public T[] ToArray<T>(Func<RC_d62ad7391a87381616a77aeae304e183, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2334acea7cfd80330b429c488fa4f97 recordList, Func<RC_d62ad7391a87381616a77aeae304e183, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2334acea7cfd80330b429c488fa4f97(RC_d62ad7391a87381616a77aeae304e183[] array) {
  RL_f2334acea7cfd80330b429c488fa4f97 result = new RL_f2334acea7cfd80330b429c488fa4f97();
result.InnerFromArray(array);
    return result;
}

public static RL_f2334acea7cfd80330b429c488fa4f97 ToList<T>(T[] array, Func <T, RC_d62ad7391a87381616a77aeae304e183> converter) {
  RL_f2334acea7cfd80330b429c488fa4f97 result = new RL_f2334acea7cfd80330b429c488fa4f97();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2334acea7cfd80330b429c488fa4f97 FromRestList<T>(RestList<T> restList, Func <T, RC_d62ad7391a87381616a77aeae304e183> converter) {
  RL_f2334acea7cfd80330b429c488fa4f97 result = new RL_f2334acea7cfd80330b429c488fa4f97();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2334acea7cfd80330b429c488fa4f97() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d62ad7391a87381616a77aeae304e183> NewList() {
return new RL_f2334acea7cfd80330b429c488fa4f97();
}


} // RL_f2334acea7cfd80330b429c488fa4f97
}

