namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_CONTA_FACTURASReq (1F6NXK1D5UCFg3UjBNYhNA)
///  <code>ST_012aef00497ef6b298e25799608b1289Structure</code> that represent
/// s <code>ZMXFFIMF_CONTA_FACTURASReq</code> <p>Description: ZMXFFIMF_CONTA_FACTURASReq</p>
/// </summary>
// Name: ZMXFFIMF_CONTA_FACTURASReq
public partial struct ST_012aef00497ef6b298e25799608b1289Structure : ITypedRecord<ST_012aef00497ef6b298e25799608b1289Structure> {
internal static readonly GlobalObjectKey IdPI_BUS_AREA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*L5lAnyVz4k+gkGaDsTVJQg");
internal static readonly GlobalObjectKey IdPI_COMP_CODE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*fmcLOyJkXk2_cWK58MPU2Q");
internal static readonly GlobalObjectKey IdPI_DB_CR_IND = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*3+gopp_ILEuNS69A6AvBXQ");
internal static readonly GlobalObjectKey IdPI_GL_ACCOUNT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*SIyGSYbJyUmcD4LlmQ4qeg");
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Tj5GlSlYQ0SuMbkwGI+z0Q");
internal static readonly GlobalObjectKey IdPI_INVOICE_DOC_ITEM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*SnqI5Qiex0+9PlHGgbtjaw");
internal static readonly GlobalObjectKey IdPI_ITEM_AMOUNT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*v1fgvO34+06j96KwZ1fdRQ");
internal static readonly GlobalObjectKey IdPI_UUID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*WiRsBGwD+Ua_ws8CuhmGSw");
internal static readonly GlobalObjectKey IdTI_ITEM_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ZfZ7jozWaUSYJn7xe+0GuQ");
internal static readonly GlobalObjectKey IdTI_WXD_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*LavhIwylgkqQ1GOp9NOj8w");

public string ssPI_BUS_AREA;

public string ssPI_COMP_CODE;

public string ssPI_DB_CR_IND;

public string ssPI_GL_ACCOUNT;

public ST_f4885e4f480f4a52f6c05031eda6ef37Structure ssPI_HEADER;

public int ssPI_INVOICE_DOC_ITEM;

public decimal ssPI_ITEM_AMOUNT;

public string ssPI_UUID;

public RL_1c06eebb48d1b54a899c0d33bdf93a52 ssTI_ITEM_In;

public RL_f2d9c802fb1adc89fda1ad392c027309 ssTI_WXD_In;


public BitArray OptimizedAttributes;

public ST_012aef00497ef6b298e25799608b1289Structure() {
OptimizedAttributes = null;
ssPI_BUS_AREA = "";
ssPI_COMP_CODE = "";
ssPI_DB_CR_IND = "";
ssPI_GL_ACCOUNT = "";
ssPI_HEADER = new ST_f4885e4f480f4a52f6c05031eda6ef37Structure();
ssPI_INVOICE_DOC_ITEM = 0;
ssPI_ITEM_AMOUNT = 0.0M;
ssPI_UUID = "";
ssTI_ITEM_In = new RL_1c06eebb48d1b54a899c0d33bdf93a52();
ssTI_WXD_In = new RL_f2d9c802fb1adc89fda1ad392c027309();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssPI_HEADER.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPI_BUS_AREA = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_BUS_AREA", "");
ssPI_COMP_CODE = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_COMP_CODE", "");
ssPI_DB_CR_IND = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_DB_CR_IND", "");
ssPI_GL_ACCOUNT = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_GL_ACCOUNT", "");
ssPI_INVOICE_DOC_ITEM = r.ReadInteger(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_INVOICE_DOC_ITEM", 0);
ssPI_ITEM_AMOUNT = r.ReadDecimal(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_ITEM_AMOUNT", 0.0M);
ssPI_UUID = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASReq.PI_UUID", "");
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
public void ReadIM(ST_012aef00497ef6b298e25799608b1289Structure r) {
this = r;
}


public static bool operator == (ST_012aef00497ef6b298e25799608b1289Structure a, ST_012aef00497ef6b298e25799608b1289Structure b) {
if (a.ssPI_BUS_AREA != b.ssPI_BUS_AREA) return false;
if (a.ssPI_COMP_CODE != b.ssPI_COMP_CODE) return false;
if (a.ssPI_DB_CR_IND != b.ssPI_DB_CR_IND) return false;
if (a.ssPI_GL_ACCOUNT != b.ssPI_GL_ACCOUNT) return false;
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_INVOICE_DOC_ITEM != b.ssPI_INVOICE_DOC_ITEM) return false;
if (a.ssPI_ITEM_AMOUNT != b.ssPI_ITEM_AMOUNT) return false;
if (a.ssPI_UUID != b.ssPI_UUID) return false;
if (a.ssTI_ITEM_In != b.ssTI_ITEM_In) return false;
if (a.ssTI_WXD_In != b.ssTI_WXD_In) return false;
return true;
}

public static bool operator != (ST_012aef00497ef6b298e25799608b1289Structure a, ST_012aef00497ef6b298e25799608b1289Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_012aef00497ef6b298e25799608b1289Structure)) return false;
return (this == (ST_012aef00497ef6b298e25799608b1289Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_BUS_AREA.GetHashCode()
 ^ ssPI_COMP_CODE.GetHashCode()
 ^ ssPI_DB_CR_IND.GetHashCode()
 ^ ssPI_GL_ACCOUNT.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_INVOICE_DOC_ITEM.GetHashCode()
 ^ ssPI_ITEM_AMOUNT.GetHashCode()
 ^ ssPI_UUID.GetHashCode()
 ^ ssTI_ITEM_In.GetHashCode()
 ^ ssTI_WXD_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssTI_ITEM_In.RecursiveReset();
ssTI_WXD_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssTI_ITEM_In.InternalRecursiveSave();
ssTI_WXD_In.InternalRecursiveSave();
}


public ST_012aef00497ef6b298e25799608b1289Structure Duplicate() {
ST_012aef00497ef6b298e25799608b1289Structure t;
t.ssPI_BUS_AREA = this.ssPI_BUS_AREA;
t.ssPI_COMP_CODE = this.ssPI_COMP_CODE;
t.ssPI_DB_CR_IND = this.ssPI_DB_CR_IND;
t.ssPI_GL_ACCOUNT = this.ssPI_GL_ACCOUNT;
t.ssPI_HEADER = (ST_f4885e4f480f4a52f6c05031eda6ef37Structure)this.ssPI_HEADER.Duplicate();
t.ssPI_INVOICE_DOC_ITEM = this.ssPI_INVOICE_DOC_ITEM;
t.ssPI_ITEM_AMOUNT = this.ssPI_ITEM_AMOUNT;
t.ssPI_UUID = this.ssPI_UUID;
t.ssTI_ITEM_In = (RL_1c06eebb48d1b54a899c0d33bdf93a52)this.ssTI_ITEM_In.Duplicate();
t.ssTI_WXD_In = (RL_f2d9c802fb1adc89fda1ad392c027309)this.ssTI_WXD_In.Duplicate();
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
if (head == "pi_bus_area") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_BUS_AREA")) variable.Value = ssPI_BUS_AREA; else variable.Optimized = true;
} else if (head == "pi_comp_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_COMP_CODE")) variable.Value = ssPI_COMP_CODE; else variable.Optimized = true;
} else if (head == "pi_db_cr_ind") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_DB_CR_IND")) variable.Value = ssPI_DB_CR_IND; else variable.Optimized = true;
} else if (head == "pi_gl_account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_GL_ACCOUNT")) variable.Value = ssPI_GL_ACCOUNT; else variable.Optimized = true;
} else if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
} else if (head == "pi_invoice_doc_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_INVOICE_DOC_ITEM")) variable.Value = ssPI_INVOICE_DOC_ITEM; else variable.Optimized = true;
} else if (head == "pi_item_amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_AMOUNT")) variable.Value = ssPI_ITEM_AMOUNT; else variable.Optimized = true;
} else if (head == "pi_uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_UUID")) variable.Value = ssPI_UUID; else variable.Optimized = true;
} else if (head == "ti_item_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_ITEM_In")) variable.Value = ssTI_ITEM_In; else variable.Optimized = true;
variable.SetFieldName("ti_item_in");
} else if (head == "ti_wxd_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_WXD_In")) variable.Value = ssTI_WXD_In; else variable.Optimized = true;
variable.SetFieldName("ti_wxd_in");
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
if (key == IdPI_BUS_AREA) {
return ssPI_BUS_AREA;
}
if (key == IdPI_COMP_CODE) {
return ssPI_COMP_CODE;
}
if (key == IdPI_DB_CR_IND) {
return ssPI_DB_CR_IND;
}
if (key == IdPI_GL_ACCOUNT) {
return ssPI_GL_ACCOUNT;
}
if (key == IdPI_HEADER) {
return ssPI_HEADER;
}
if (key == IdPI_INVOICE_DOC_ITEM) {
return ssPI_INVOICE_DOC_ITEM;
}
if (key == IdPI_ITEM_AMOUNT) {
return ssPI_ITEM_AMOUNT;
}
if (key == IdPI_UUID) {
return ssPI_UUID;
}
if (key == IdTI_ITEM_In) {
return ssTI_ITEM_In;
}
if (key == IdTI_WXD_In) {
return ssTI_WXD_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_BUS_AREA.Key.AsGuid) {
return ssPI_BUS_AREA;
}
if (attributeKey == IdPI_COMP_CODE.Key.AsGuid) {
return ssPI_COMP_CODE;
}
if (attributeKey == IdPI_DB_CR_IND.Key.AsGuid) {
return ssPI_DB_CR_IND;
}
if (attributeKey == IdPI_GL_ACCOUNT.Key.AsGuid) {
return ssPI_GL_ACCOUNT;
}
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_INVOICE_DOC_ITEM.Key.AsGuid) {
return ssPI_INVOICE_DOC_ITEM;
}
if (attributeKey == IdPI_ITEM_AMOUNT.Key.AsGuid) {
return ssPI_ITEM_AMOUNT;
}
if (attributeKey == IdPI_UUID.Key.AsGuid) {
return ssPI_UUID;
}
if (attributeKey == IdTI_ITEM_In.Key.AsGuid) {
return ssTI_ITEM_In;
}
if (attributeKey == IdTI_WXD_In.Key.AsGuid) {
return ssTI_WXD_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_BUS_AREA = (string) other.AttributeGet(IdPI_BUS_AREA);
ssPI_COMP_CODE = (string) other.AttributeGet(IdPI_COMP_CODE);
ssPI_DB_CR_IND = (string) other.AttributeGet(IdPI_DB_CR_IND);
ssPI_GL_ACCOUNT = (string) other.AttributeGet(IdPI_GL_ACCOUNT);
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_INVOICE_DOC_ITEM = (int) other.AttributeGet(IdPI_INVOICE_DOC_ITEM);
ssPI_ITEM_AMOUNT = (decimal) other.AttributeGet(IdPI_ITEM_AMOUNT);
ssPI_UUID = (string) other.AttributeGet(IdPI_UUID);
ssTI_ITEM_In = new RL_1c06eebb48d1b54a899c0d33bdf93a52();
ssTI_ITEM_In.FillFromOther((IOSList) other.AttributeGet(IdTI_ITEM_In));
ssTI_WXD_In = new RL_f2d9c802fb1adc89fda1ad392c027309();
ssTI_WXD_In.FillFromOther((IOSList) other.AttributeGet(IdTI_WXD_In));
}
} // ST_012aef00497ef6b298e25799608b1289Structure
/// <summary>
/// RecordList type <code>ZMXFFIMF_CONTA_FACTURASReqList</code> that represents a record list of
///  <code>ZMXFFIMF_CONTA_FACTURASReq</code>
/// </summary>
public partial class RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 : GenericRecordList<ST_012aef00497ef6b298e25799608b1289Structure>, IEnumerable, IEnumerator {

protected override ST_012aef00497ef6b298e25799608b1289Structure GetElementDefaultValue() {
return new ST_012aef00497ef6b298e25799608b1289Structure();
}

public T[] ToArray<T>(Func<ST_012aef00497ef6b298e25799608b1289Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 recordList, Func<ST_012aef00497ef6b298e25799608b1289Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c53af0ce1ce35f1f7a981c2bbe76c1b7(ST_012aef00497ef6b298e25799608b1289Structure[] array) {
  RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 result = new RL_c53af0ce1ce35f1f7a981c2bbe76c1b7();
result.InnerFromArray(array);
    return result;
}

public static RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 ToList<T>(T[] array, Func <T, ST_012aef00497ef6b298e25799608b1289Structure> converter) {
  RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 result = new RL_c53af0ce1ce35f1f7a981c2bbe76c1b7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 FromRestList<T>(RestList<T> restList, Func <T, ST_012aef00497ef6b298e25799608b1289Structure> converter) {
  RL_c53af0ce1ce35f1f7a981c2bbe76c1b7 result = new RL_c53af0ce1ce35f1f7a981c2bbe76c1b7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c53af0ce1ce35f1f7a981c2bbe76c1b7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_012aef00497ef6b298e25799608b1289Structure> NewList() {
return new RL_c53af0ce1ce35f1f7a981c2bbe76c1b7();
}


} // RL_c53af0ce1ce35f1f7a981c2bbe76c1b7
}

