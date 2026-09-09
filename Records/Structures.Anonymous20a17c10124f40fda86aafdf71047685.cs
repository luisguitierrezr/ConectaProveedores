namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EHyhIE8S_UCoaq_fcQR2hQ)
///  <code>RC_bbf6ac66012cd4c117435ee07fe47293</code> that represent
/// s <code>UserFolioFolioLogRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFolioFolioLogRecord
public partial struct RC_bbf6ac66012cd4c117435ee07fe47293 : ITypedRecord<RC_bbf6ac66012cd4c117435ee07fe47293> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4q_F0TKorVCOJU710qKbAQ");

public ENUserEntityRecord ssENUser;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord ssENFolioLog;


public BitArray OptimizedAttributes;

public RC_bbf6ac66012cd4c117435ee07fe47293() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioLog = new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioLog.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioLog.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioLog.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENFolioLog.Read( r, ref index);
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
public void ReadIM(RC_bbf6ac66012cd4c117435ee07fe47293 r) {
this = r;
}


public static bool operator == (RC_bbf6ac66012cd4c117435ee07fe47293 a, RC_bbf6ac66012cd4c117435ee07fe47293 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioLog != b.ssENFolioLog) return false;
return true;
}

public static bool operator != (RC_bbf6ac66012cd4c117435ee07fe47293 a, RC_bbf6ac66012cd4c117435ee07fe47293 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bbf6ac66012cd4c117435ee07fe47293)) return false;
return (this == (RC_bbf6ac66012cd4c117435ee07fe47293)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioLog.InternalRecursiveSave();
}


public RC_bbf6ac66012cd4c117435ee07fe47293 Duplicate() {
RC_bbf6ac66012cd4c117435ee07fe47293 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioLog = (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord)this.ssENFolioLog.Duplicate();
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
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "foliolog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioLog")) variable.Value = ssENFolioLog; else variable.Optimized = true;
variable.SetFieldName("foliolog");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioLog) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioLog.Key.AsGuid) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioLog.FillFromOther((IRecord) other.AttributeGet(IdFolioLog));
}
} // RC_bbf6ac66012cd4c117435ee07fe47293
/// <summary>
/// RecordList type <code>UserFolioFolioLogRecordList</code> that represents a record list of
///  <code>User, Folio, FolioLog</code>
/// </summary>
public partial class RL_dee17ce4f31506555cb30478e439c102 : GenericRecordList<RC_bbf6ac66012cd4c117435ee07fe47293>, IEnumerable, IEnumerator {

protected override RC_bbf6ac66012cd4c117435ee07fe47293 GetElementDefaultValue() {
return new RC_bbf6ac66012cd4c117435ee07fe47293();
}

public T[] ToArray<T>(Func<RC_bbf6ac66012cd4c117435ee07fe47293, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dee17ce4f31506555cb30478e439c102 recordList, Func<RC_bbf6ac66012cd4c117435ee07fe47293, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dee17ce4f31506555cb30478e439c102(RC_bbf6ac66012cd4c117435ee07fe47293[] array) {
  RL_dee17ce4f31506555cb30478e439c102 result = new RL_dee17ce4f31506555cb30478e439c102();
result.InnerFromArray(array);
    return result;
}

public static RL_dee17ce4f31506555cb30478e439c102 ToList<T>(T[] array, Func <T, RC_bbf6ac66012cd4c117435ee07fe47293> converter) {
  RL_dee17ce4f31506555cb30478e439c102 result = new RL_dee17ce4f31506555cb30478e439c102();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dee17ce4f31506555cb30478e439c102 FromRestList<T>(RestList<T> restList, Func <T, RC_bbf6ac66012cd4c117435ee07fe47293> converter) {
  RL_dee17ce4f31506555cb30478e439c102 result = new RL_dee17ce4f31506555cb30478e439c102();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dee17ce4f31506555cb30478e439c102() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bbf6ac66012cd4c117435ee07fe47293> NewList() {
return new RL_dee17ce4f31506555cb30478e439c102();
}


} // RL_dee17ce4f31506555cb30478e439c102
}

