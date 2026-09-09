namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderRequestFileStruct (Sw9L1W6ReEeZqGa46dZZUQ)
///  <code>ST_d9010d115c38fb059bccbc457fe11b18Structure</code> that represent
/// s <code>OrderRequestFileStruct</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileStruct
public partial struct ST_d9010d115c38fb059bccbc457fe11b18Structure : ITypedRecord<ST_d9010d115c38fb059bccbc457fe11b18Structure> {
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R3jYfK6hZEqZUSt7xB372A");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ndu_cNZrRkeA7fm8YD9N1g");

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssOrderRequestFile;

public byte[] ssBinary;


public BitArray OptimizedAttributes;

public ST_d9010d115c38fb059bccbc457fe11b18Structure() {
OptimizedAttributes = null;
ssOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssBinary = new byte[] {};
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssOrderRequestFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssOrderRequestFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssBinary = r.ReadBinaryData(index++, "OrderRequestFileStruct.Binary", new byte[] {});
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
public void ReadIM(ST_d9010d115c38fb059bccbc457fe11b18Structure r) {
this = r;
}


public static bool operator == (ST_d9010d115c38fb059bccbc457fe11b18Structure a, ST_d9010d115c38fb059bccbc457fe11b18Structure b) {
if (a.ssOrderRequestFile != b.ssOrderRequestFile) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
return true;
}

public static bool operator != (ST_d9010d115c38fb059bccbc457fe11b18Structure a, ST_d9010d115c38fb059bccbc457fe11b18Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d9010d115c38fb059bccbc457fe11b18Structure)) return false;
return (this == (ST_d9010d115c38fb059bccbc457fe11b18Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderRequestFile.GetHashCode()
 ^ ssBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOrderRequestFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOrderRequestFile.InternalRecursiveSave();
}


public ST_d9010d115c38fb059bccbc457fe11b18Structure Duplicate() {
ST_d9010d115c38fb059bccbc457fe11b18Structure t;
t.ssOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssOrderRequestFile.Duplicate();
t.ssBinary = this.ssBinary;
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
if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
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
if (key == IdOrderRequestFile) {
return ssOrderRequestFile;
}
if (key == IdBinary) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssOrderRequestFile;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssBinary = (byte[]) other.AttributeGet(IdBinary);
}
} // ST_d9010d115c38fb059bccbc457fe11b18Structure
/// <summary>
/// RecordList type <code>OrderRequestFileStructList</code> that represents a record list of
///  <code>OrderRequestFileStruct</code>
/// </summary>
public partial class RL_9d3b4c4e80b371ac0dc01854afca347a : GenericRecordList<ST_d9010d115c38fb059bccbc457fe11b18Structure>, IEnumerable, IEnumerator {

protected override ST_d9010d115c38fb059bccbc457fe11b18Structure GetElementDefaultValue() {
return new ST_d9010d115c38fb059bccbc457fe11b18Structure();
}

public T[] ToArray<T>(Func<ST_d9010d115c38fb059bccbc457fe11b18Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9d3b4c4e80b371ac0dc01854afca347a recordList, Func<ST_d9010d115c38fb059bccbc457fe11b18Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9d3b4c4e80b371ac0dc01854afca347a(ST_d9010d115c38fb059bccbc457fe11b18Structure[] array) {
  RL_9d3b4c4e80b371ac0dc01854afca347a result = new RL_9d3b4c4e80b371ac0dc01854afca347a();
result.InnerFromArray(array);
    return result;
}

public static RL_9d3b4c4e80b371ac0dc01854afca347a ToList<T>(T[] array, Func <T, ST_d9010d115c38fb059bccbc457fe11b18Structure> converter) {
  RL_9d3b4c4e80b371ac0dc01854afca347a result = new RL_9d3b4c4e80b371ac0dc01854afca347a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9d3b4c4e80b371ac0dc01854afca347a FromRestList<T>(RestList<T> restList, Func <T, ST_d9010d115c38fb059bccbc457fe11b18Structure> converter) {
  RL_9d3b4c4e80b371ac0dc01854afca347a result = new RL_9d3b4c4e80b371ac0dc01854afca347a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9d3b4c4e80b371ac0dc01854afca347a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d9010d115c38fb059bccbc457fe11b18Structure> NewList() {
return new RL_9d3b4c4e80b371ac0dc01854afca347a();
}


} // RL_9d3b4c4e80b371ac0dc01854afca347a
}

