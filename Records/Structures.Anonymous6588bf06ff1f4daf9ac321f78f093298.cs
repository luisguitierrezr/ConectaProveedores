namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Br+IZR__r02awyH3jwkymA)
///  <code>RC_38bf7bcb20a8b257cedfd0071956fdaa</code> that represent
/// s <code>UserProposalLogsRecord</code> <p>Description: </p>
/// </summary>
// Name: UserProposalLogsRecord
public partial struct RC_38bf7bcb20a8b257cedfd0071956fdaa : ITypedRecord<RC_38bf7bcb20a8b257cedfd0071956fdaa> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdProposalLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*25fSQlZTWuzLhGXgl3hJwA");

public ENUserEntityRecord ssENUser;

public EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs;


public BitArray OptimizedAttributes;

public RC_38bf7bcb20a8b257cedfd0071956fdaa() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENProposalLogs = new EN_013f76cfa3062515b73935963b1697b0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLogs.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENProposalLogs.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENProposalLogs.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENProposalLogs.Read( r, ref index);
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
public void ReadIM(RC_38bf7bcb20a8b257cedfd0071956fdaa r) {
this = r;
}


public static bool operator == (RC_38bf7bcb20a8b257cedfd0071956fdaa a, RC_38bf7bcb20a8b257cedfd0071956fdaa b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENProposalLogs != b.ssENProposalLogs) return false;
return true;
}

public static bool operator != (RC_38bf7bcb20a8b257cedfd0071956fdaa a, RC_38bf7bcb20a8b257cedfd0071956fdaa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_38bf7bcb20a8b257cedfd0071956fdaa)) return false;
return (this == (RC_38bf7bcb20a8b257cedfd0071956fdaa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENProposalLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENProposalLogs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENProposalLogs.InternalRecursiveSave();
}


public RC_38bf7bcb20a8b257cedfd0071956fdaa Duplicate() {
RC_38bf7bcb20a8b257cedfd0071956fdaa t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENProposalLogs = (EN_013f76cfa3062515b73935963b1697b0EntityRecord)this.ssENProposalLogs.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "proposallogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLogs")) variable.Value = ssENProposalLogs; else variable.Optimized = true;
variable.SetFieldName("proposallogs");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdProposalLogs) {
return ssENProposalLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdProposalLogs.Key.AsGuid) {
return ssENProposalLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENProposalLogs.FillFromOther((IRecord) other.AttributeGet(IdProposalLogs));
}
} // RC_38bf7bcb20a8b257cedfd0071956fdaa
/// <summary>
/// RecordList type <code>UserProposalLogsRecordList</code> that represents a record list of
///  <code>User, ProposalLogs</code>
/// </summary>
public partial class RL_f6f48bf2db0bc517dcae1aa52c83f316 : GenericRecordList<RC_38bf7bcb20a8b257cedfd0071956fdaa>, IEnumerable, IEnumerator {

protected override RC_38bf7bcb20a8b257cedfd0071956fdaa GetElementDefaultValue() {
return new RC_38bf7bcb20a8b257cedfd0071956fdaa();
}

public T[] ToArray<T>(Func<RC_38bf7bcb20a8b257cedfd0071956fdaa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6f48bf2db0bc517dcae1aa52c83f316 recordList, Func<RC_38bf7bcb20a8b257cedfd0071956fdaa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6f48bf2db0bc517dcae1aa52c83f316(RC_38bf7bcb20a8b257cedfd0071956fdaa[] array) {
  RL_f6f48bf2db0bc517dcae1aa52c83f316 result = new RL_f6f48bf2db0bc517dcae1aa52c83f316();
result.InnerFromArray(array);
    return result;
}

public static RL_f6f48bf2db0bc517dcae1aa52c83f316 ToList<T>(T[] array, Func <T, RC_38bf7bcb20a8b257cedfd0071956fdaa> converter) {
  RL_f6f48bf2db0bc517dcae1aa52c83f316 result = new RL_f6f48bf2db0bc517dcae1aa52c83f316();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6f48bf2db0bc517dcae1aa52c83f316 FromRestList<T>(RestList<T> restList, Func <T, RC_38bf7bcb20a8b257cedfd0071956fdaa> converter) {
  RL_f6f48bf2db0bc517dcae1aa52c83f316 result = new RL_f6f48bf2db0bc517dcae1aa52c83f316();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6f48bf2db0bc517dcae1aa52c83f316() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_38bf7bcb20a8b257cedfd0071956fdaa> NewList() {
return new RL_f6f48bf2db0bc517dcae1aa52c83f316();
}


} // RL_f6f48bf2db0bc517dcae1aa52c83f316
}

