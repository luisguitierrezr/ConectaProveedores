namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ElKTgLrEBUiBVMiYA82ATA)
///  <code>RC_185879ac9d2186c1424cb37de7de8668</code> that represent
/// s <code>UserUser_Extended_InternalRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUser_Extended_InternalRegionRecord
public partial struct RC_185879ac9d2186c1424cb37de7de8668 : ITypedRecord<RC_185879ac9d2186c1424cb37de7de8668> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_185879ac9d2186c1424cb37de7de8668() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
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
ssENUser_Extended_Internal.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_185879ac9d2186c1424cb37de7de8668 r) {
this = r;
}


public static bool operator == (RC_185879ac9d2186c1424cb37de7de8668 a, RC_185879ac9d2186c1424cb37de7de8668 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_185879ac9d2186c1424cb37de7de8668 a, RC_185879ac9d2186c1424cb37de7de8668 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_185879ac9d2186c1424cb37de7de8668)) return false;
return (this == (RC_185879ac9d2186c1424cb37de7de8668)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_185879ac9d2186c1424cb37de7de8668 Duplicate() {
RC_185879ac9d2186c1424cb37de7de8668 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_185879ac9d2186c1424cb37de7de8668
/// <summary>
/// RecordList type <code>UserUser_Extended_InternalRegionRecordList</code> that represents a record
///  list of <code>User, User_Extended_Internal, Region</code>
/// </summary>
public partial class RL_1543a4f2af6703945e350e1348a6aecf : GenericRecordList<RC_185879ac9d2186c1424cb37de7de8668>, IEnumerable, IEnumerator {

protected override RC_185879ac9d2186c1424cb37de7de8668 GetElementDefaultValue() {
return new RC_185879ac9d2186c1424cb37de7de8668();
}

public T[] ToArray<T>(Func<RC_185879ac9d2186c1424cb37de7de8668, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1543a4f2af6703945e350e1348a6aecf recordList, Func<RC_185879ac9d2186c1424cb37de7de8668, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1543a4f2af6703945e350e1348a6aecf(RC_185879ac9d2186c1424cb37de7de8668[] array) {
  RL_1543a4f2af6703945e350e1348a6aecf result = new RL_1543a4f2af6703945e350e1348a6aecf();
result.InnerFromArray(array);
    return result;
}

public static RL_1543a4f2af6703945e350e1348a6aecf ToList<T>(T[] array, Func <T, RC_185879ac9d2186c1424cb37de7de8668> converter) {
  RL_1543a4f2af6703945e350e1348a6aecf result = new RL_1543a4f2af6703945e350e1348a6aecf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1543a4f2af6703945e350e1348a6aecf FromRestList<T>(RestList<T> restList, Func <T, RC_185879ac9d2186c1424cb37de7de8668> converter) {
  RL_1543a4f2af6703945e350e1348a6aecf result = new RL_1543a4f2af6703945e350e1348a6aecf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1543a4f2af6703945e350e1348a6aecf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_185879ac9d2186c1424cb37de7de8668> NewList() {
return new RL_1543a4f2af6703945e350e1348a6aecf();
}


} // RL_1543a4f2af6703945e350e1348a6aecf
}

