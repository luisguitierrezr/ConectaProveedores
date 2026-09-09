namespace ssConectaProveedores {
/// <summary>
/// [Structure] MFU_Error (bzVZRn_wNUO19I_C4tZsmw)
///  <code>ST_f9f8b40f5330871047e55e068d129447Structure</code> that represents <code>MFU_Error</code
/// > <p>Description: Error Structure</p>
/// </summary>
// Name: MFU_Error
public partial struct ST_f9f8b40f5330871047e55e068d129447Structure : ITypedRecord<ST_f9f8b40f5330871047e55e068d129447Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pcyn86o2_EyVEfYEDY0aAA");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iNmMhjibKEuE2n7lKujvRg");

public bool ssSuccess;

public string ssErrorMessage;


public BitArray OptimizedAttributes;

public ST_f9f8b40f5330871047e55e068d129447Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssErrorMessage = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSuccess = r.ReadBoolean(index++, "MFU_Error.Success", false);
ssErrorMessage = r.ReadText(index++, "MFU_Error.ErrorMessage", "");
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
public void ReadIM(ST_f9f8b40f5330871047e55e068d129447Structure r) {
this = r;
}


public static bool operator == (ST_f9f8b40f5330871047e55e068d129447Structure a, ST_f9f8b40f5330871047e55e068d129447Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (ST_f9f8b40f5330871047e55e068d129447Structure a, ST_f9f8b40f5330871047e55e068d129447Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f9f8b40f5330871047e55e068d129447Structure)) return false;
return (this == (ST_f9f8b40f5330871047e55e068d129447Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f9f8b40f5330871047e55e068d129447Structure Duplicate() {
ST_f9f8b40f5330871047e55e068d129447Structure t;
t.ssSuccess = this.ssSuccess;
t.ssErrorMessage = this.ssErrorMessage;
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
}
} // ST_f9f8b40f5330871047e55e068d129447Structure
/// <summary>
/// RecordList type <code>MFU_ErrorList</code> that represents a record list of <code>MFU_Error</code>
/// </summary>
public partial class RL_6870eb164aad1a469b89d5a69d202b32 : GenericRecordList<ST_f9f8b40f5330871047e55e068d129447Structure>, IEnumerable, IEnumerator {

protected override ST_f9f8b40f5330871047e55e068d129447Structure GetElementDefaultValue() {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
}

public T[] ToArray<T>(Func<ST_f9f8b40f5330871047e55e068d129447Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6870eb164aad1a469b89d5a69d202b32 recordList, Func<ST_f9f8b40f5330871047e55e068d129447Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6870eb164aad1a469b89d5a69d202b32(ST_f9f8b40f5330871047e55e068d129447Structure[] array) {
  RL_6870eb164aad1a469b89d5a69d202b32 result = new RL_6870eb164aad1a469b89d5a69d202b32();
result.InnerFromArray(array);
    return result;
}

public static RL_6870eb164aad1a469b89d5a69d202b32 ToList<T>(T[] array, Func <T, ST_f9f8b40f5330871047e55e068d129447Structure> converter) {
  RL_6870eb164aad1a469b89d5a69d202b32 result = new RL_6870eb164aad1a469b89d5a69d202b32();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6870eb164aad1a469b89d5a69d202b32 FromRestList<T>(RestList<T> restList, Func <T, ST_f9f8b40f5330871047e55e068d129447Structure> converter) {
  RL_6870eb164aad1a469b89d5a69d202b32 result = new RL_6870eb164aad1a469b89d5a69d202b32();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6870eb164aad1a469b89d5a69d202b32() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f9f8b40f5330871047e55e068d129447Structure> NewList() {
return new RL_6870eb164aad1a469b89d5a69d202b32();
}


} // RL_6870eb164aad1a469b89d5a69d202b32
}

