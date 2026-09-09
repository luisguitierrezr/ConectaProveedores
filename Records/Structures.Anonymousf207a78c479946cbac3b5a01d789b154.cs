namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jKcH8plHy0asO1oB14mxVA)
///  <code>RC_131b941598d8581e5466dbb966f5f0a8</code> that represent
/// s <code>FolioApprovalFolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioApprovalLevelRecord
public partial struct RC_131b941598d8581e5466dbb966f5f0a8 : ITypedRecord<RC_131b941598d8581e5466dbb966f5f0a8> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_131b941598d8581e5466dbb966f5f0a8() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
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
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolioApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolioApprovalLevel.OptimizedAttributes;
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
ssENFolioApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_131b941598d8581e5466dbb966f5f0a8 r) {
this = r;
}


public static bool operator == (RC_131b941598d8581e5466dbb966f5f0a8 a, RC_131b941598d8581e5466dbb966f5f0a8 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_131b941598d8581e5466dbb966f5f0a8 a, RC_131b941598d8581e5466dbb966f5f0a8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_131b941598d8581e5466dbb966f5f0a8)) return false;
return (this == (RC_131b941598d8581e5466dbb966f5f0a8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_131b941598d8581e5466dbb966f5f0a8 Duplicate() {
RC_131b941598d8581e5466dbb966f5f0a8 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
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
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_131b941598d8581e5466dbb966f5f0a8
/// <summary>
/// RecordList type <code>FolioApprovalFolioApprovalLevelRecordList</code> that represents a record
///  list of <code>FolioApproval, FolioApprovalLevel</code>
/// </summary>
public partial class RL_52e01c48f1745de5266c16d6fe2c0564 : GenericRecordList<RC_131b941598d8581e5466dbb966f5f0a8>, IEnumerable, IEnumerator {

protected override RC_131b941598d8581e5466dbb966f5f0a8 GetElementDefaultValue() {
return new RC_131b941598d8581e5466dbb966f5f0a8();
}

public T[] ToArray<T>(Func<RC_131b941598d8581e5466dbb966f5f0a8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_52e01c48f1745de5266c16d6fe2c0564 recordList, Func<RC_131b941598d8581e5466dbb966f5f0a8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_52e01c48f1745de5266c16d6fe2c0564(RC_131b941598d8581e5466dbb966f5f0a8[] array) {
  RL_52e01c48f1745de5266c16d6fe2c0564 result = new RL_52e01c48f1745de5266c16d6fe2c0564();
result.InnerFromArray(array);
    return result;
}

public static RL_52e01c48f1745de5266c16d6fe2c0564 ToList<T>(T[] array, Func <T, RC_131b941598d8581e5466dbb966f5f0a8> converter) {
  RL_52e01c48f1745de5266c16d6fe2c0564 result = new RL_52e01c48f1745de5266c16d6fe2c0564();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_52e01c48f1745de5266c16d6fe2c0564 FromRestList<T>(RestList<T> restList, Func <T, RC_131b941598d8581e5466dbb966f5f0a8> converter) {
  RL_52e01c48f1745de5266c16d6fe2c0564 result = new RL_52e01c48f1745de5266c16d6fe2c0564();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_52e01c48f1745de5266c16d6fe2c0564() : base() {
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
protected override OSList<RC_131b941598d8581e5466dbb966f5f0a8> NewList() {
return new RL_52e01c48f1745de5266c16d6fe2c0564();
}


} // RL_52e01c48f1745de5266c16d6fe2c0564
}

