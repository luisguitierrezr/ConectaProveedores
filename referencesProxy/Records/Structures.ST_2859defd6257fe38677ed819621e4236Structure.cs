namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_RETENCIONES_In (Db6u_tBe606j1a_jLMwXoQ)
///  <code>ST_2859defd6257fe38677ed819621e4236Structure</code> that represent
/// s <code>TI_RETENCIONES_In</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_In
public partial struct ST_2859defd6257fe38677ed819621e4236Structure : ITypedRecord<ST_2859defd6257fe38677ed819621e4236Structure> {
internal static readonly GlobalObjectKey IdLIFNR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*WkTpAmAwGU6N7sZ2WaOMIQ");
internal static readonly GlobalObjectKey IdBUKRS = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*fwv45rjJQEWWg2EmuYOAxA");
internal static readonly GlobalObjectKey IdWITHT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*TxUAyajClkuLBcYZTo07qg");
internal static readonly GlobalObjectKey IdWT_WITHCD = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*MJKfMdxoKEOUaxnPd+Bljw");
internal static readonly GlobalObjectKey IdWT_SUBJCT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*pjHhBX0EL06jsimCBr41NA");

public string ssLIFNR;

public string ssBUKRS;

public string ssWITHT;

public string ssWT_WITHCD;

public string ssWT_SUBJCT;


public BitArray OptimizedAttributes;

public ST_2859defd6257fe38677ed819621e4236Structure() {
OptimizedAttributes = null;
ssLIFNR = "";
ssBUKRS = "";
ssWITHT = "";
ssWT_WITHCD = "";
ssWT_SUBJCT = "";
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
ssLIFNR = r.ReadText(index++, "TI_RETENCIONES_In.LIFNR", "");
ssBUKRS = r.ReadText(index++, "TI_RETENCIONES_In.BUKRS", "");
ssWITHT = r.ReadText(index++, "TI_RETENCIONES_In.WITHT", "");
ssWT_WITHCD = r.ReadText(index++, "TI_RETENCIONES_In.WT_WITHCD", "");
ssWT_SUBJCT = r.ReadText(index++, "TI_RETENCIONES_In.WT_SUBJCT", "");
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
public void ReadIM(ST_2859defd6257fe38677ed819621e4236Structure r) {
this = r;
}


public static bool operator == (ST_2859defd6257fe38677ed819621e4236Structure a, ST_2859defd6257fe38677ed819621e4236Structure b) {
if (a.ssLIFNR != b.ssLIFNR) return false;
if (a.ssBUKRS != b.ssBUKRS) return false;
if (a.ssWITHT != b.ssWITHT) return false;
if (a.ssWT_WITHCD != b.ssWT_WITHCD) return false;
if (a.ssWT_SUBJCT != b.ssWT_SUBJCT) return false;
return true;
}

public static bool operator != (ST_2859defd6257fe38677ed819621e4236Structure a, ST_2859defd6257fe38677ed819621e4236Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2859defd6257fe38677ed819621e4236Structure)) return false;
return (this == (ST_2859defd6257fe38677ed819621e4236Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLIFNR.GetHashCode()
 ^ ssBUKRS.GetHashCode()
 ^ ssWITHT.GetHashCode()
 ^ ssWT_WITHCD.GetHashCode()
 ^ ssWT_SUBJCT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2859defd6257fe38677ed819621e4236Structure Duplicate() {
ST_2859defd6257fe38677ed819621e4236Structure t;
t.ssLIFNR = this.ssLIFNR;
t.ssBUKRS = this.ssBUKRS;
t.ssWITHT = this.ssWITHT;
t.ssWT_WITHCD = this.ssWT_WITHCD;
t.ssWT_SUBJCT = this.ssWT_SUBJCT;
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
} else if (head == "bukrs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BUKRS")) variable.Value = ssBUKRS; else variable.Optimized = true;
} else if (head == "witht") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WITHT")) variable.Value = ssWITHT; else variable.Optimized = true;
} else if (head == "wt_withcd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_WITHCD")) variable.Value = ssWT_WITHCD; else variable.Optimized = true;
} else if (head == "wt_subjct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_SUBJCT")) variable.Value = ssWT_SUBJCT; else variable.Optimized = true;
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
if (key == IdBUKRS) {
return ssBUKRS;
}
if (key == IdWITHT) {
return ssWITHT;
}
if (key == IdWT_WITHCD) {
return ssWT_WITHCD;
}
if (key == IdWT_SUBJCT) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLIFNR.Key.AsGuid) {
return ssLIFNR;
}
if (attributeKey == IdBUKRS.Key.AsGuid) {
return ssBUKRS;
}
if (attributeKey == IdWITHT.Key.AsGuid) {
return ssWITHT;
}
if (attributeKey == IdWT_WITHCD.Key.AsGuid) {
return ssWT_WITHCD;
}
if (attributeKey == IdWT_SUBJCT.Key.AsGuid) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLIFNR = (string) other.AttributeGet(IdLIFNR);
ssBUKRS = (string) other.AttributeGet(IdBUKRS);
ssWITHT = (string) other.AttributeGet(IdWITHT);
ssWT_WITHCD = (string) other.AttributeGet(IdWT_WITHCD);
ssWT_SUBJCT = (string) other.AttributeGet(IdWT_SUBJCT);
}
} // ST_2859defd6257fe38677ed819621e4236Structure
/// <summary>
/// RecordList type <code>TI_RETENCIONES_InList</code> that represents a record list of
///  <code>TI_RETENCIONES_In</code>
/// </summary>
public partial class RL_772621b2ef7c10f920402993065f4a21 : GenericRecordList<ST_2859defd6257fe38677ed819621e4236Structure>, IEnumerable, IEnumerator {

protected override ST_2859defd6257fe38677ed819621e4236Structure GetElementDefaultValue() {
return new ST_2859defd6257fe38677ed819621e4236Structure();
}

public T[] ToArray<T>(Func<ST_2859defd6257fe38677ed819621e4236Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_772621b2ef7c10f920402993065f4a21 recordList, Func<ST_2859defd6257fe38677ed819621e4236Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_772621b2ef7c10f920402993065f4a21(ST_2859defd6257fe38677ed819621e4236Structure[] array) {
  RL_772621b2ef7c10f920402993065f4a21 result = new RL_772621b2ef7c10f920402993065f4a21();
result.InnerFromArray(array);
    return result;
}

public static RL_772621b2ef7c10f920402993065f4a21 ToList<T>(T[] array, Func <T, ST_2859defd6257fe38677ed819621e4236Structure> converter) {
  RL_772621b2ef7c10f920402993065f4a21 result = new RL_772621b2ef7c10f920402993065f4a21();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_772621b2ef7c10f920402993065f4a21 FromRestList<T>(RestList<T> restList, Func <T, ST_2859defd6257fe38677ed819621e4236Structure> converter) {
  RL_772621b2ef7c10f920402993065f4a21 result = new RL_772621b2ef7c10f920402993065f4a21();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_772621b2ef7c10f920402993065f4a21() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2859defd6257fe38677ed819621e4236Structure> NewList() {
return new RL_772621b2ef7c10f920402993065f4a21();
}


} // RL_772621b2ef7c10f920402993065f4a21
}

