namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TO_RESULTADO_Out (vzK1KD5rokOy55C+CKCUPw)
///  <code>ST_1ca05235ee87feb8ff9907143d7de852Structure</code> that represent
/// s <code>TO_RESULTADO_Out</code> <p>Description: </p>
/// </summary>
// Name: TO_RESULTADO_Out
public partial struct ST_1ca05235ee87feb8ff9907143d7de852Structure : ITypedRecord<ST_1ca05235ee87feb8ff9907143d7de852Structure> {
internal static readonly GlobalObjectKey IdID_POLIZA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*yycKVkwOAEuFyBFVPmq8aQ");
internal static readonly GlobalObjectKey IdCODIGO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*ikLeXflVKkCpBxM7cC+8uQ");
internal static readonly GlobalObjectKey IdTEXTO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*GqLQED+hQk+Ga2G_VEk1OA");

public string ssID_POLIZA;

public string ssCODIGO;

public string ssTEXTO;


public BitArray OptimizedAttributes;

public ST_1ca05235ee87feb8ff9907143d7de852Structure() {
OptimizedAttributes = null;
ssID_POLIZA = "";
ssCODIGO = "";
ssTEXTO = "";
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
ssID_POLIZA = r.ReadText(index++, "TO_RESULTADO_Out.ID_POLIZA", "");
ssCODIGO = r.ReadText(index++, "TO_RESULTADO_Out.CODIGO", "");
ssTEXTO = r.ReadText(index++, "TO_RESULTADO_Out.TEXTO", "");
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
public void ReadIM(ST_1ca05235ee87feb8ff9907143d7de852Structure r) {
this = r;
}


public static bool operator == (ST_1ca05235ee87feb8ff9907143d7de852Structure a, ST_1ca05235ee87feb8ff9907143d7de852Structure b) {
if (a.ssID_POLIZA != b.ssID_POLIZA) return false;
if (a.ssCODIGO != b.ssCODIGO) return false;
if (a.ssTEXTO != b.ssTEXTO) return false;
return true;
}

public static bool operator != (ST_1ca05235ee87feb8ff9907143d7de852Structure a, ST_1ca05235ee87feb8ff9907143d7de852Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1ca05235ee87feb8ff9907143d7de852Structure)) return false;
return (this == (ST_1ca05235ee87feb8ff9907143d7de852Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssID_POLIZA.GetHashCode()
 ^ ssCODIGO.GetHashCode()
 ^ ssTEXTO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1ca05235ee87feb8ff9907143d7de852Structure Duplicate() {
ST_1ca05235ee87feb8ff9907143d7de852Structure t;
t.ssID_POLIZA = this.ssID_POLIZA;
t.ssCODIGO = this.ssCODIGO;
t.ssTEXTO = this.ssTEXTO;
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
if (head == "id_poliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_POLIZA")) variable.Value = ssID_POLIZA; else variable.Optimized = true;
} else if (head == "codigo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CODIGO")) variable.Value = ssCODIGO; else variable.Optimized = true;
} else if (head == "texto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO")) variable.Value = ssTEXTO; else variable.Optimized = true;
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
if (key == IdID_POLIZA) {
return ssID_POLIZA;
}
if (key == IdCODIGO) {
return ssCODIGO;
}
if (key == IdTEXTO) {
return ssTEXTO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdID_POLIZA.Key.AsGuid) {
return ssID_POLIZA;
}
if (attributeKey == IdCODIGO.Key.AsGuid) {
return ssCODIGO;
}
if (attributeKey == IdTEXTO.Key.AsGuid) {
return ssTEXTO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssID_POLIZA = (string) other.AttributeGet(IdID_POLIZA);
ssCODIGO = (string) other.AttributeGet(IdCODIGO);
ssTEXTO = (string) other.AttributeGet(IdTEXTO);
}
} // ST_1ca05235ee87feb8ff9907143d7de852Structure
/// <summary>
/// RecordList type <code>TO_RESULTADO_OutList</code> that represents a record list of
///  <code>TO_RESULTADO_Out</code>
/// </summary>
public partial class RL_48c08abdc43583e242f48c4245aed919 : GenericRecordList<ST_1ca05235ee87feb8ff9907143d7de852Structure>, IEnumerable, IEnumerator {

protected override ST_1ca05235ee87feb8ff9907143d7de852Structure GetElementDefaultValue() {
return new ST_1ca05235ee87feb8ff9907143d7de852Structure();
}

public T[] ToArray<T>(Func<ST_1ca05235ee87feb8ff9907143d7de852Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_48c08abdc43583e242f48c4245aed919 recordList, Func<ST_1ca05235ee87feb8ff9907143d7de852Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_48c08abdc43583e242f48c4245aed919(ST_1ca05235ee87feb8ff9907143d7de852Structure[] array) {
  RL_48c08abdc43583e242f48c4245aed919 result = new RL_48c08abdc43583e242f48c4245aed919();
result.InnerFromArray(array);
    return result;
}

public static RL_48c08abdc43583e242f48c4245aed919 ToList<T>(T[] array, Func <T, ST_1ca05235ee87feb8ff9907143d7de852Structure> converter) {
  RL_48c08abdc43583e242f48c4245aed919 result = new RL_48c08abdc43583e242f48c4245aed919();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_48c08abdc43583e242f48c4245aed919 FromRestList<T>(RestList<T> restList, Func <T, ST_1ca05235ee87feb8ff9907143d7de852Structure> converter) {
  RL_48c08abdc43583e242f48c4245aed919 result = new RL_48c08abdc43583e242f48c4245aed919();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_48c08abdc43583e242f48c4245aed919() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1ca05235ee87feb8ff9907143d7de852Structure> NewList() {
return new RL_48c08abdc43583e242f48c4245aed919();
}


} // RL_48c08abdc43583e242f48c4245aed919
}

