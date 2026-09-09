namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] T_DAT_PROV_In (IwwL_lJnaUq4d+wBiL3_uA)
///  <code>ST_b19d23fc0038c4f52f978d3d75427ea7Structure</code> that represent
/// s <code>T_DAT_PROV_In</code> <p>Description: </p>
/// </summary>
// Name: T_DAT_PROV_In
public partial struct ST_b19d23fc0038c4f52f978d3d75427ea7Structure : ITypedRecord<ST_b19d23fc0038c4f52f978d3d75427ea7Structure> {
internal static readonly GlobalObjectKey IdLIFNR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*w+iFLMw0+k64e30zXZ_1PA");
internal static readonly GlobalObjectKey IdNAME1 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*zW1PhIJL_0yY0cyy5IoHYA");
internal static readonly GlobalObjectKey IdNAME2 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*DacQmhGllUK5r8pU8Oa5zA");

public string ssLIFNR;

public string ssNAME1;

public string ssNAME2;


public BitArray OptimizedAttributes;

public ST_b19d23fc0038c4f52f978d3d75427ea7Structure() {
OptimizedAttributes = null;
ssLIFNR = "";
ssNAME1 = "";
ssNAME2 = "";
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
ssLIFNR = r.ReadText(index++, "T_DAT_PROV_In.LIFNR", "");
ssNAME1 = r.ReadText(index++, "T_DAT_PROV_In.NAME1", "");
ssNAME2 = r.ReadText(index++, "T_DAT_PROV_In.NAME2", "");
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
public void ReadIM(ST_b19d23fc0038c4f52f978d3d75427ea7Structure r) {
this = r;
}


public static bool operator == (ST_b19d23fc0038c4f52f978d3d75427ea7Structure a, ST_b19d23fc0038c4f52f978d3d75427ea7Structure b) {
if (a.ssLIFNR != b.ssLIFNR) return false;
if (a.ssNAME1 != b.ssNAME1) return false;
if (a.ssNAME2 != b.ssNAME2) return false;
return true;
}

public static bool operator != (ST_b19d23fc0038c4f52f978d3d75427ea7Structure a, ST_b19d23fc0038c4f52f978d3d75427ea7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b19d23fc0038c4f52f978d3d75427ea7Structure)) return false;
return (this == (ST_b19d23fc0038c4f52f978d3d75427ea7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLIFNR.GetHashCode()
 ^ ssNAME1.GetHashCode()
 ^ ssNAME2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b19d23fc0038c4f52f978d3d75427ea7Structure Duplicate() {
ST_b19d23fc0038c4f52f978d3d75427ea7Structure t;
t.ssLIFNR = this.ssLIFNR;
t.ssNAME1 = this.ssNAME1;
t.ssNAME2 = this.ssNAME2;
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
if (head == "lifnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LIFNR")) variable.Value = ssLIFNR; else variable.Optimized = true;
} else if (head == "name1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NAME1")) variable.Value = ssNAME1; else variable.Optimized = true;
} else if (head == "name2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NAME2")) variable.Value = ssNAME2; else variable.Optimized = true;
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
if (key == IdLIFNR) {
return ssLIFNR;
}
if (key == IdNAME1) {
return ssNAME1;
}
if (key == IdNAME2) {
return ssNAME2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLIFNR.Key.AsGuid) {
return ssLIFNR;
}
if (attributeKey == IdNAME1.Key.AsGuid) {
return ssNAME1;
}
if (attributeKey == IdNAME2.Key.AsGuid) {
return ssNAME2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLIFNR = (string) other.AttributeGet(IdLIFNR);
ssNAME1 = (string) other.AttributeGet(IdNAME1);
ssNAME2 = (string) other.AttributeGet(IdNAME2);
}
} // ST_b19d23fc0038c4f52f978d3d75427ea7Structure
/// <summary>
/// RecordList type <code>T_DAT_PROV_InList</code> that represents a record list of
///  <code>T_DAT_PROV_In</code>
/// </summary>
public partial class RL_26f0bf6a8c3a397fae12e4e85231dc16 : GenericRecordList<ST_b19d23fc0038c4f52f978d3d75427ea7Structure>, IEnumerable, IEnumerator {

protected override ST_b19d23fc0038c4f52f978d3d75427ea7Structure GetElementDefaultValue() {
return new ST_b19d23fc0038c4f52f978d3d75427ea7Structure();
}

public T[] ToArray<T>(Func<ST_b19d23fc0038c4f52f978d3d75427ea7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26f0bf6a8c3a397fae12e4e85231dc16 recordList, Func<ST_b19d23fc0038c4f52f978d3d75427ea7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26f0bf6a8c3a397fae12e4e85231dc16(ST_b19d23fc0038c4f52f978d3d75427ea7Structure[] array) {
  RL_26f0bf6a8c3a397fae12e4e85231dc16 result = new RL_26f0bf6a8c3a397fae12e4e85231dc16();
result.InnerFromArray(array);
    return result;
}

public static RL_26f0bf6a8c3a397fae12e4e85231dc16 ToList<T>(T[] array, Func <T, ST_b19d23fc0038c4f52f978d3d75427ea7Structure> converter) {
  RL_26f0bf6a8c3a397fae12e4e85231dc16 result = new RL_26f0bf6a8c3a397fae12e4e85231dc16();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26f0bf6a8c3a397fae12e4e85231dc16 FromRestList<T>(RestList<T> restList, Func <T, ST_b19d23fc0038c4f52f978d3d75427ea7Structure> converter) {
  RL_26f0bf6a8c3a397fae12e4e85231dc16 result = new RL_26f0bf6a8c3a397fae12e4e85231dc16();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26f0bf6a8c3a397fae12e4e85231dc16() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b19d23fc0038c4f52f978d3d75427ea7Structure> NewList() {
return new RL_26f0bf6a8c3a397fae12e4e85231dc16();
}


} // RL_26f0bf6a8c3a397fae12e4e85231dc16
}

