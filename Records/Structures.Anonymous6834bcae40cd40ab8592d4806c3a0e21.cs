namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rrw0aM1Aq0CFktSAbDoOIQ)
///  <code>RC_9af5a4e48bf7682fd78edcb92b1adec9</code> that represent
/// s <code>FolioApprovalFolioApprovalLevelFolioCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioApprovalLevelFolioCommentRecord
public partial struct RC_9af5a4e48bf7682fd78edcb92b1adec9 : ITypedRecord<RC_9af5a4e48bf7682fd78edcb92b1adec9> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdFolioComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_WlMvWoooT+644ij1orABw");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment;


public BitArray OptimizedAttributes;

public RC_9af5a4e48bf7682fd78edcb92b1adec9() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENFolioComment = new EN_a75639301080da49357fc03810b8d65fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioComment.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolioApprovalLevel.OptimizedAttributes = value[1];
    ssENFolioComment.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[2] = ssENFolioComment.OptimizedAttributes;
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
public void ReadIM(RC_9af5a4e48bf7682fd78edcb92b1adec9 r) {
this = r;
}


public static bool operator == (RC_9af5a4e48bf7682fd78edcb92b1adec9 a, RC_9af5a4e48bf7682fd78edcb92b1adec9 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENFolioComment != b.ssENFolioComment) return false;
return true;
}

public static bool operator != (RC_9af5a4e48bf7682fd78edcb92b1adec9 a, RC_9af5a4e48bf7682fd78edcb92b1adec9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9af5a4e48bf7682fd78edcb92b1adec9)) return false;
return (this == (RC_9af5a4e48bf7682fd78edcb92b1adec9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENFolioComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENFolioComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENFolioComment.InternalRecursiveSave();
}


public RC_9af5a4e48bf7682fd78edcb92b1adec9 Duplicate() {
RC_9af5a4e48bf7682fd78edcb92b1adec9 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
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
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdFolioComment) {
return ssENFolioComment;
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
if (attributeKey == IdFolioComment.Key.AsGuid) {
return ssENFolioComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENFolioComment.FillFromOther((IRecord) other.AttributeGet(IdFolioComment));
}
} // RC_9af5a4e48bf7682fd78edcb92b1adec9
/// <summary>
/// RecordList type <code>FolioApprovalFolioApprovalLevelFolioCommentRecordList</code> that represents
///  a record list of <code>FolioApproval, FolioApprovalLevel, FolioComment</code>
/// </summary>
public partial class RL_29173c8e71b738f340ed8a29f378afba : GenericRecordList<RC_9af5a4e48bf7682fd78edcb92b1adec9>, IEnumerable, IEnumerator {

protected override RC_9af5a4e48bf7682fd78edcb92b1adec9 GetElementDefaultValue() {
return new RC_9af5a4e48bf7682fd78edcb92b1adec9();
}

public T[] ToArray<T>(Func<RC_9af5a4e48bf7682fd78edcb92b1adec9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_29173c8e71b738f340ed8a29f378afba recordList, Func<RC_9af5a4e48bf7682fd78edcb92b1adec9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_29173c8e71b738f340ed8a29f378afba(RC_9af5a4e48bf7682fd78edcb92b1adec9[] array) {
  RL_29173c8e71b738f340ed8a29f378afba result = new RL_29173c8e71b738f340ed8a29f378afba();
result.InnerFromArray(array);
    return result;
}

public static RL_29173c8e71b738f340ed8a29f378afba ToList<T>(T[] array, Func <T, RC_9af5a4e48bf7682fd78edcb92b1adec9> converter) {
  RL_29173c8e71b738f340ed8a29f378afba result = new RL_29173c8e71b738f340ed8a29f378afba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_29173c8e71b738f340ed8a29f378afba FromRestList<T>(RestList<T> restList, Func <T, RC_9af5a4e48bf7682fd78edcb92b1adec9> converter) {
  RL_29173c8e71b738f340ed8a29f378afba result = new RL_29173c8e71b738f340ed8a29f378afba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_29173c8e71b738f340ed8a29f378afba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9af5a4e48bf7682fd78edcb92b1adec9> NewList() {
return new RL_29173c8e71b738f340ed8a29f378afba();
}


} // RL_29173c8e71b738f340ed8a29f378afba
}

