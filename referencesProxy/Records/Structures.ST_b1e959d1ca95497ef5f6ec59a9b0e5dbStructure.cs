namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_POS_In (uSXmW+t9PUeK0lL2ybN0yg)
///  <code>ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure</code> that represents <code>TI_POS_In</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_POS_In
public partial struct ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure : ITypedRecord<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> {
internal static readonly GlobalObjectKey IdPARAMETRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*3Mxt8wmqrE6HQlIshwaqAA");

public string ssPARAMETRO;


public BitArray OptimizedAttributes;

public ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure() {
OptimizedAttributes = null;
ssPARAMETRO = "";
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
ssPARAMETRO = r.ReadText(index++, "TI_POS_In.PARAMETRO", "");
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
public void ReadIM(ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure r) {
this = r;
}


public static bool operator == (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure a, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure b) {
if (a.ssPARAMETRO != b.ssPARAMETRO) return false;
return true;
}

public static bool operator != (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure a, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure)) return false;
return (this == (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPARAMETRO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure Duplicate() {
ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure t;
t.ssPARAMETRO = this.ssPARAMETRO;
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
if (head == "parametro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PARAMETRO")) variable.Value = ssPARAMETRO; else variable.Optimized = true;
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
if (key == IdPARAMETRO) {
return ssPARAMETRO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPARAMETRO.Key.AsGuid) {
return ssPARAMETRO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPARAMETRO = (string) other.AttributeGet(IdPARAMETRO);
}
} // ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure
/// <summary>
/// RecordList type <code>TI_POS_InList</code> that represents a record list of <code>TI_POS_In</code>
/// </summary>
public partial class RL_c68103fa9d6dc1b51b6298518d880199 : GenericRecordList<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure>, IEnumerable, IEnumerator {

protected override ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure GetElementDefaultValue() {
return new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure();
}

public T[] ToArray<T>(Func<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c68103fa9d6dc1b51b6298518d880199 recordList, Func<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c68103fa9d6dc1b51b6298518d880199(ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure[] array) {
  RL_c68103fa9d6dc1b51b6298518d880199 result = new RL_c68103fa9d6dc1b51b6298518d880199();
result.InnerFromArray(array);
    return result;
}

public static RL_c68103fa9d6dc1b51b6298518d880199 ToList<T>(T[] array, Func <T, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> converter) {
  RL_c68103fa9d6dc1b51b6298518d880199 result = new RL_c68103fa9d6dc1b51b6298518d880199();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c68103fa9d6dc1b51b6298518d880199 FromRestList<T>(RestList<T> restList, Func <T, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> converter) {
  RL_c68103fa9d6dc1b51b6298518d880199 result = new RL_c68103fa9d6dc1b51b6298518d880199();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c68103fa9d6dc1b51b6298518d880199() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> NewList() {
return new RL_c68103fa9d6dc1b51b6298518d880199();
}


} // RL_c68103fa9d6dc1b51b6298518d880199
}

