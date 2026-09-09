namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (49WOkuptqUGSPisxiVqcIQ)
///  <code>RC_06b38e19582fc855dd67cd4191332383</code> that represent
/// s <code>UserUser_2CompanyRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUser_2CompanyRecord
public partial struct RC_06b38e19582fc855dd67cd4191332383 : ITypedRecord<RC_06b38e19582fc855dd67cd4191332383> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5F23_wlsRH5bBFQUXYstpQ");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");

public ENUserEntityRecord ssENUser;

public ENUserEntityRecord ssENUser_2;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;


public BitArray OptimizedAttributes;

public RC_06b38e19582fc855dd67cd4191332383() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_2 = new ENUserEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_2.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_2.OptimizedAttributes = value[1];
    ssENCompany.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_2.OptimizedAttributes;
    all[2] = ssENCompany.OptimizedAttributes;
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
ssENUser_2.Read( r, ref index);
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_06b38e19582fc855dd67cd4191332383 r) {
this = r;
}


public static bool operator == (RC_06b38e19582fc855dd67cd4191332383 a, RC_06b38e19582fc855dd67cd4191332383 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_2 != b.ssENUser_2) return false;
if (a.ssENCompany != b.ssENCompany) return false;
return true;
}

public static bool operator != (RC_06b38e19582fc855dd67cd4191332383 a, RC_06b38e19582fc855dd67cd4191332383 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_06b38e19582fc855dd67cd4191332383)) return false;
return (this == (RC_06b38e19582fc855dd67cd4191332383)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_2.GetHashCode()
 ^ ssENCompany.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_2.RecursiveReset();
ssENCompany.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_2.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
}


public RC_06b38e19582fc855dd67cd4191332383 Duplicate() {
RC_06b38e19582fc855dd67cd4191332383 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_2 = (ENUserEntityRecord)this.ssENUser_2.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "user_2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_2")) variable.Value = ssENUser_2; else variable.Optimized = true;
variable.SetFieldName("user_2");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdUser_2) {
return ssENUser_2;
}
if (key == IdCompany) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUser_2.Key.AsGuid) {
return ssENUser_2;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_2.FillFromOther((IRecord) other.AttributeGet(IdUser_2));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
}
} // RC_06b38e19582fc855dd67cd4191332383
/// <summary>
/// RecordList type <code>UserUser_2CompanyRecordList</code> that represents a record list of
///  <code>User, User, Company</code>
/// </summary>
public partial class RL_1409548829f9518cbebb0e467312ef87 : GenericRecordList<RC_06b38e19582fc855dd67cd4191332383>, IEnumerable, IEnumerator {

protected override RC_06b38e19582fc855dd67cd4191332383 GetElementDefaultValue() {
return new RC_06b38e19582fc855dd67cd4191332383();
}

public T[] ToArray<T>(Func<RC_06b38e19582fc855dd67cd4191332383, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1409548829f9518cbebb0e467312ef87 recordList, Func<RC_06b38e19582fc855dd67cd4191332383, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1409548829f9518cbebb0e467312ef87(RC_06b38e19582fc855dd67cd4191332383[] array) {
  RL_1409548829f9518cbebb0e467312ef87 result = new RL_1409548829f9518cbebb0e467312ef87();
result.InnerFromArray(array);
    return result;
}

public static RL_1409548829f9518cbebb0e467312ef87 ToList<T>(T[] array, Func <T, RC_06b38e19582fc855dd67cd4191332383> converter) {
  RL_1409548829f9518cbebb0e467312ef87 result = new RL_1409548829f9518cbebb0e467312ef87();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1409548829f9518cbebb0e467312ef87 FromRestList<T>(RestList<T> restList, Func <T, RC_06b38e19582fc855dd67cd4191332383> converter) {
  RL_1409548829f9518cbebb0e467312ef87 result = new RL_1409548829f9518cbebb0e467312ef87();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1409548829f9518cbebb0e467312ef87() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_06b38e19582fc855dd67cd4191332383> NewList() {
return new RL_1409548829f9518cbebb0e467312ef87();
}


} // RL_1409548829f9518cbebb0e467312ef87
}

