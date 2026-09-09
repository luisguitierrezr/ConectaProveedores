namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AWHzYHbli0GiYQ9kXV7QPg)
///  <code>RC_234ff55477e8affa6c928b8c8c03aedb</code> that represent
/// s
///  <code>CreatedByRevokedBySourceUserTargetUserFolioReassignmentsFolioApprovalLevelOrderMainRecord</co
/// de> <p>Description: </p>
/// </summary>
// Name: CreatedByRevokedBySourceUserTargetUserFolioReassignmentsFolioApprovalLevelOrderMainRecord
public partial struct RC_234ff55477e8affa6c928b8c8c03aedb : ITypedRecord<RC_234ff55477e8affa6c928b8c8c03aedb> {
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FGuvhVB10PrccNTbIpFT7w");
internal static readonly GlobalObjectKey IdRevokedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FXdxCUlrBFct23n5T+ePUQ");
internal static readonly GlobalObjectKey IdSourceUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fZN31ZjFWTACTQWmoXQInQ");
internal static readonly GlobalObjectKey IdTargetUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zi2_YshgWDFLnZEnulCh2g");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdReassignments = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HE45yXcxCSJVD0bH9gDW7g");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public ENUserEntityRecord ssENCreatedBy;

public ENUserEntityRecord ssENRevokedBy;

public ENUserEntityRecord ssENSourceUser;

public ENUserEntityRecord ssENTargetUser;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_234ff55477e8affa6c928b8c8c03aedb() {
OptimizedAttributes = null;
ssENCreatedBy = new ENUserEntityRecord();
ssENRevokedBy = new ENUserEntityRecord();
ssENSourceUser = new ENUserEntityRecord();
ssENTargetUser = new ENUserEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENReassignments = new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(5,false);
    all[4] = new BitArray(20,false);
    all[5] = new BitArray(17,false);
    all[6] = new BitArray(20,false);
    all[7] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCreatedBy.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRevokedBy.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSourceUser.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENTargetUser.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENReassignments.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENCreatedBy.OptimizedAttributes = value[0];
    ssENRevokedBy.OptimizedAttributes = value[1];
    ssENSourceUser.OptimizedAttributes = value[2];
    ssENTargetUser.OptimizedAttributes = value[3];
    ssENFolio.OptimizedAttributes = value[4];
    ssENReassignments.OptimizedAttributes = value[5];
    ssENFolioApprovalLevel.OptimizedAttributes = value[6];
    ssENOrderMain.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENCreatedBy.OptimizedAttributes;
    all[1] = ssENRevokedBy.OptimizedAttributes;
    all[2] = ssENSourceUser.OptimizedAttributes;
    all[3] = ssENTargetUser.OptimizedAttributes;
    all[4] = ssENFolio.OptimizedAttributes;
    all[5] = ssENReassignments.OptimizedAttributes;
    all[6] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[7] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCreatedBy.Read( r, ref index);
ssENRevokedBy.Read( r, ref index);
ssENSourceUser.Read( r, ref index);
ssENTargetUser.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENReassignments.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_234ff55477e8affa6c928b8c8c03aedb r) {
this = r;
}


public static bool operator == (RC_234ff55477e8affa6c928b8c8c03aedb a, RC_234ff55477e8affa6c928b8c8c03aedb b) {
if (a.ssENCreatedBy != b.ssENCreatedBy) return false;
if (a.ssENRevokedBy != b.ssENRevokedBy) return false;
if (a.ssENSourceUser != b.ssENSourceUser) return false;
if (a.ssENTargetUser != b.ssENTargetUser) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENReassignments != b.ssENReassignments) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_234ff55477e8affa6c928b8c8c03aedb a, RC_234ff55477e8affa6c928b8c8c03aedb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_234ff55477e8affa6c928b8c8c03aedb)) return false;
return (this == (RC_234ff55477e8affa6c928b8c8c03aedb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCreatedBy.GetHashCode()
 ^ ssENRevokedBy.GetHashCode()
 ^ ssENSourceUser.GetHashCode()
 ^ ssENTargetUser.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENReassignments.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCreatedBy.RecursiveReset();
ssENRevokedBy.RecursiveReset();
ssENSourceUser.RecursiveReset();
ssENTargetUser.RecursiveReset();
ssENFolio.RecursiveReset();
ssENReassignments.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCreatedBy.InternalRecursiveSave();
ssENRevokedBy.InternalRecursiveSave();
ssENSourceUser.InternalRecursiveSave();
ssENTargetUser.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENReassignments.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_234ff55477e8affa6c928b8c8c03aedb Duplicate() {
RC_234ff55477e8affa6c928b8c8c03aedb t;
t.ssENCreatedBy = (ENUserEntityRecord)this.ssENCreatedBy.Duplicate();
t.ssENRevokedBy = (ENUserEntityRecord)this.ssENRevokedBy.Duplicate();
t.ssENSourceUser = (ENUserEntityRecord)this.ssENSourceUser.Duplicate();
t.ssENTargetUser = (ENUserEntityRecord)this.ssENTargetUser.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENReassignments = (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord)this.ssENReassignments.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssENCreatedBy; else variable.Optimized = true;
variable.SetFieldName("createdby");
} else if (head == "revokedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RevokedBy")) variable.Value = ssENRevokedBy; else variable.Optimized = true;
variable.SetFieldName("revokedby");
} else if (head == "sourceuser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SourceUser")) variable.Value = ssENSourceUser; else variable.Optimized = true;
variable.SetFieldName("sourceuser");
} else if (head == "targetuser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetUser")) variable.Value = ssENTargetUser; else variable.Optimized = true;
variable.SetFieldName("targetuser");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "reassignments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Reassignments")) variable.Value = ssENReassignments; else variable.Optimized = true;
variable.SetFieldName("reassignments");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdCreatedBy) {
return ssENCreatedBy;
}
if (key == IdRevokedBy) {
return ssENRevokedBy;
}
if (key == IdSourceUser) {
return ssENSourceUser;
}
if (key == IdTargetUser) {
return ssENTargetUser;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdReassignments) {
return ssENReassignments;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssENCreatedBy;
}
if (attributeKey == IdRevokedBy.Key.AsGuid) {
return ssENRevokedBy;
}
if (attributeKey == IdSourceUser.Key.AsGuid) {
return ssENSourceUser;
}
if (attributeKey == IdTargetUser.Key.AsGuid) {
return ssENTargetUser;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdReassignments.Key.AsGuid) {
return ssENReassignments;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCreatedBy.FillFromOther((IRecord) other.AttributeGet(IdCreatedBy));
ssENRevokedBy.FillFromOther((IRecord) other.AttributeGet(IdRevokedBy));
ssENSourceUser.FillFromOther((IRecord) other.AttributeGet(IdSourceUser));
ssENTargetUser.FillFromOther((IRecord) other.AttributeGet(IdTargetUser));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENReassignments.FillFromOther((IRecord) other.AttributeGet(IdReassignments));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_234ff55477e8affa6c928b8c8c03aedb
/// <summary>
/// RecordList type
///  <code>CreatedByRevokedBySourceUserTargetUserFolioReassignmentsFolioApprovalLevelOrderMainRecordList
/// </code> that represents a record list of <code>User, User, User, User, Folio, Reassignments,
///  FolioApprovalLevel, OrderMain</code>
/// </summary>
public partial class RL_4d1a87a21136b2184fa5a9ef787f7fd6 : GenericRecordList<RC_234ff55477e8affa6c928b8c8c03aedb>, IEnumerable, IEnumerator {

protected override RC_234ff55477e8affa6c928b8c8c03aedb GetElementDefaultValue() {
return new RC_234ff55477e8affa6c928b8c8c03aedb();
}

public T[] ToArray<T>(Func<RC_234ff55477e8affa6c928b8c8c03aedb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d1a87a21136b2184fa5a9ef787f7fd6 recordList, Func<RC_234ff55477e8affa6c928b8c8c03aedb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d1a87a21136b2184fa5a9ef787f7fd6(RC_234ff55477e8affa6c928b8c8c03aedb[] array) {
  RL_4d1a87a21136b2184fa5a9ef787f7fd6 result = new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
result.InnerFromArray(array);
    return result;
}

public static RL_4d1a87a21136b2184fa5a9ef787f7fd6 ToList<T>(T[] array, Func <T, RC_234ff55477e8affa6c928b8c8c03aedb> converter) {
  RL_4d1a87a21136b2184fa5a9ef787f7fd6 result = new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d1a87a21136b2184fa5a9ef787f7fd6 FromRestList<T>(RestList<T> restList, Func <T, RC_234ff55477e8affa6c928b8c8c03aedb> converter) {
  RL_4d1a87a21136b2184fa5a9ef787f7fd6 result = new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d1a87a21136b2184fa5a9ef787f7fd6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(5,false);
def[4] = new BitArray(20,false);
def[5] = new BitArray(17,false);
def[6] = new BitArray(20,false);
def[7] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_234ff55477e8affa6c928b8c8c03aedb> NewList() {
return new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
}


} // RL_4d1a87a21136b2184fa5a9ef787f7fd6
}

