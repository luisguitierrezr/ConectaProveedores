namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+lLM30IsaEWj_NkEe+IDQg)
///  <code>RC_184336c68155ad9e77005f91e8e8b363</code> that represent
/// s <code>UserUserExtensionUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserExtensionUser_Extended_InternalRecord
public partial struct RC_184336c68155ad9e77005f91e8e8b363 : ITypedRecord<RC_184336c68155ad9e77005f91e8e8b363> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_184336c68155ad9e77005f91e8e8b363() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(3,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserExtension.OptimizedAttributes = value[1];
    ssENUser_Extended_Internal.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserExtension.OptimizedAttributes;
    all[2] = ssENUser_Extended_Internal.OptimizedAttributes;
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
ssENUserExtension.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_184336c68155ad9e77005f91e8e8b363 r) {
this = r;
}


public static bool operator == (RC_184336c68155ad9e77005f91e8e8b363 a, RC_184336c68155ad9e77005f91e8e8b363 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_184336c68155ad9e77005f91e8e8b363 a, RC_184336c68155ad9e77005f91e8e8b363 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_184336c68155ad9e77005f91e8e8b363)) return false;
return (this == (RC_184336c68155ad9e77005f91e8e8b363)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_184336c68155ad9e77005f91e8e8b363 Duplicate() {
RC_184336c68155ad9e77005f91e8e8b363 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_184336c68155ad9e77005f91e8e8b363
/// <summary>
/// RecordList type <code>UserUserExtensionUser_Extended_InternalRecordList</code> that represents a
///  record list of <code>User, UserExtension, User_Extended_Internal</code>
/// </summary>
public partial class RL_bc2063fe1d05aa544017f329fb1e030b : GenericRecordList<RC_184336c68155ad9e77005f91e8e8b363>, IEnumerable, IEnumerator {

protected override RC_184336c68155ad9e77005f91e8e8b363 GetElementDefaultValue() {
return new RC_184336c68155ad9e77005f91e8e8b363();
}

public T[] ToArray<T>(Func<RC_184336c68155ad9e77005f91e8e8b363, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bc2063fe1d05aa544017f329fb1e030b recordList, Func<RC_184336c68155ad9e77005f91e8e8b363, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bc2063fe1d05aa544017f329fb1e030b(RC_184336c68155ad9e77005f91e8e8b363[] array) {
  RL_bc2063fe1d05aa544017f329fb1e030b result = new RL_bc2063fe1d05aa544017f329fb1e030b();
result.InnerFromArray(array);
    return result;
}

public static RL_bc2063fe1d05aa544017f329fb1e030b ToList<T>(T[] array, Func <T, RC_184336c68155ad9e77005f91e8e8b363> converter) {
  RL_bc2063fe1d05aa544017f329fb1e030b result = new RL_bc2063fe1d05aa544017f329fb1e030b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bc2063fe1d05aa544017f329fb1e030b FromRestList<T>(RestList<T> restList, Func <T, RC_184336c68155ad9e77005f91e8e8b363> converter) {
  RL_bc2063fe1d05aa544017f329fb1e030b result = new RL_bc2063fe1d05aa544017f329fb1e030b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bc2063fe1d05aa544017f329fb1e030b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(3,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_184336c68155ad9e77005f91e8e8b363> NewList() {
return new RL_bc2063fe1d05aa544017f329fb1e030b();
}


} // RL_bc2063fe1d05aa544017f329fb1e030b
}

